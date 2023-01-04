using Microsoft.EntityFrameworkCore;
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
            return _appDbContext.Users.Include(a => a.Address);
        }

        public User GetUser(Guid id)
        {
            var user = _appDbContext.Users.Include(a => a.Address).SingleOrDefault(a => a.Id == id);

            if (user == null) 
            {
                throw new Exception("User not found");
            }

            return user;
        }

        public void DeleteUser(Guid id)
        {
            var user = _appDbContext.Users.SingleOrDefault(a => a.Id == id);

            _appDbContext.Users.Remove(user);
        }

        public void UpdateUser(Guid id, User user)
        {
            var u = _appDbContext.Users.Include(a => a.Address).SingleOrDefault(a => a.Id == id);

            u.Name = user.Name;
            u.Email = user.Email;
            u.Password = user.Password;
            u.Address.City = user.Address.City;
            u.Address.Street = user.Address.Street;
            u.Address.Number = user.Address.Number;
        }
    }
}
