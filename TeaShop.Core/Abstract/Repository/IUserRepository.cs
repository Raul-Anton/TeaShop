using System;
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

        void UpdateUserName(Guid id, String name);

        void UpdateUserEmail(Guid id, String email);

        void UpdateUserPassword(Guid id, String password);

        void UpdateUserAddress(Guid id, Address address);

    }
}
