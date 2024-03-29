﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Domain;

namespace TeaShop.Core.Abstract.Repository
{
    public interface IUserRepository
    {
        void AddUser(User user);

        IEnumerable<User> GetUsers();

        User GetUser(Guid id);

        void DeleteUser(Guid id);

        void UpdateUser(Guid id, User user);
    }
}
