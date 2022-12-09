using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Domain;

namespace TeaShop.Core.Abstract.Repository
{
    public interface IAddressRepository
    {
        void AddAddress(Address address);

        IEnumerable<Address> GetAddresses();

        Address GetAddress(Guid id);

        void DeleteAddress(Guid id);

        void UpdateAddressCity(Guid id, String city);

        void UpdateAddressStreet(Guid id, String street);

        void UpdateAddressNumber(Guid id, int number);

        void UpdateAddressUserId(Guid id, Guid userId);

        void UpdateAddressUser(Guid id, User user);
    }
}
