﻿using Core.Application.Database;
using Core.Application.Services;
using Core.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Core.Application.Requests.GroupMemberships.Commands
{
    public class DeleteMembershipCommand : IRequest
    {
        public int GroupMembershipId { get; set; }

        public class Handler : IRequestHandler<DeleteMembershipCommand, Unit>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IUserProvider _userProvider;

            public Handler(IUnitOfWork unitOfWork, IUserProvider userProvider)
            {
                _unitOfWork = unitOfWork;
                _userProvider = userProvider;
            }

            public async Task<Unit> Handle(DeleteMembershipCommand request, CancellationToken cancellationToken = default)
            {
                int userId = _userProvider.GetCurrentUserId();

                GroupMembership membership = await _unitOfWork.GroupMemberships
                    .GetById(request.GroupMembershipId)
                    .SingleOrDefaultAsync(cancellationToken);

                // If the user leaves the group himself
                if (membership.UserId == userId)
                {
                    IEnumerable<GroupMembership> otherMembers = await _unitOfWork.GroupMemberships
                        .GetByGroup(membership.GroupId)
                        .Where(m => m.UserId != userId)
                        .ToListAsync(cancellationToken);

                    // When there are no members left, soft-delete the group
                    if (!otherMembers.Any())
                    {
                        Group group = await _unitOfWork.Groups
                            .GetById(membership.GroupId)
                            .AsTracking()
                            .SingleOrDefaultAsync(cancellationToken);

                        group.IsDeleted = true;

                        _unitOfWork.Groups.Update(group);
                    }

                    // Make sure there is still at least one administrator
                    else if (!otherMembers.Any(member => member.IsAdmin))
                    {
                        GroupMembership newAdmin = otherMembers
                            .OrderBy(member => member.Created)
                            .First();

                        newAdmin.IsAdmin = true;

                        _unitOfWork.GroupMemberships.Update(newAdmin);
                    }
                }

                // Remove the membership
                _unitOfWork.GroupMemberships.Delete(membership);
                await _unitOfWork.CommitAsync(cancellationToken);

                return Unit.Value;
            }
        }
    }
}
