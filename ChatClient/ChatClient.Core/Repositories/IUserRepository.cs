﻿using ChatClient.Core.Models.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient.Core.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        Task<bool> IsEmailTaken(string email);
        Task<User> GetUserByEmail(string email);
    }
}
