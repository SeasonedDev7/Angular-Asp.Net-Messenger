﻿using ChatClient.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get; }
        IGroupRepository GroupRepository { get; }
        IMessageRepository MessageRepository { get; }
        IGroupMembershipRepository GroupMembershipRepository { get; }
        IMessageRecipientRepository MessageRecipientRepository { get; }
        Task<int> Commit();
    }
}