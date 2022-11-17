using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
