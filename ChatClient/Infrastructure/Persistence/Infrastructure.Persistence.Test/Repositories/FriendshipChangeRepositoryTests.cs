﻿using Core.Application.Database;
using Core.Application.Repositories;
using Core.Domain.Entities;
using Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using MockQueryable.Moq;
using Moq;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Infrastructure.Persistence.Test.Repositories
{
    public class FriendshipChangeRepositoryTests
    {
        [Fact]
        public async Task Add_ShouldAddFriendshipChange()
        {
            // Arrange
            FriendshipChange change = new FriendshipChange();

            Mock<DbSet<FriendshipChange>> friendshipChangeDbSetMock = Enumerable
                .Empty<FriendshipChange>()
                .AsQueryable()
                .BuildMockDbSet();

            Mock<IChatContext> contextMock = new Mock<IChatContext>();
            contextMock
                .Setup(m => m.FriendshipChanges)
                .Returns(friendshipChangeDbSetMock.Object);

            IFriendshipChangeRepository repository = new FriendshipChangeRepository(contextMock.Object);

            // Act
            await repository.Add(change);

            // Assert
            contextMock.Verify(m => m.FriendshipChanges.AddAsync(change, It.IsAny<CancellationToken>()));
        }
    }
}
