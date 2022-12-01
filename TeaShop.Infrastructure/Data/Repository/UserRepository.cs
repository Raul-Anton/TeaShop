using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TeaShop.Core.Abstract.Repository;
using TeaShop.Core.Domain;

namespace TeaShop.Infrastructure.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _appDbContext;

        public UserRepository(AppDbContext appDbContext) 
        {
            _appDbContext= appDbContext;
        }

        public void AddUser(User user)
        {
            _appDbContext.Users.Add(user);
        }

        public IEnumerable<User> GetUsers()
        {
            return _appDbContext.Users.ToList();
        }

        public void DeleteUser(Guid id)
        {
            foreach (var user in _appDbContext.Users.ToList())
            {
                if (user.Id == id)
                {
                    _appDbContext.Users.Remove(user);
                }
            }
        }

        public void UpdateUserName(Guid id, string name)
        {
            foreach (var user in _appDbContext.Users.ToList())
            {
                if (user.Id == id)
                {
                    user.Name = name;
                }
            }
        }

        public void UpdateUserEmail(Guid id, string email)
        {
            foreach (var user in _appDbContext.Users.ToList())
            {
                if (user.Id == id)
                {
                    user.Email = email;
                }
            }
        }

        public void UpdateUser(Guid id, string password)
        {
            foreach (var user in _appDbContext.Users.ToList())
            {
                if (user.Id == id)
                {
                    user.Password = password;
                }
            }
        }
    }
}
