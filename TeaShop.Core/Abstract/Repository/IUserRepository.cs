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

        void DeleteUser(Guid id);

        void UpdateUserName(Guid id, String name);

        void UpdateUserEmail(Guid id, String email);

        void UpdateUser(Guid id, String password);

        //void UpdateUser(Guid id, Address address);

    }
}
