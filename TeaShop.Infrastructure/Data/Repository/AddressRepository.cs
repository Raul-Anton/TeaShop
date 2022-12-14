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
    public class AddressRepository : IAddressRepository
    {
        private readonly AppDbContext _appDbContext;

        public AddressRepository(AppDbContext appDbContext)
        {
            _appDbContext= appDbContext;
        }

        public void AddAddress(Address address)
        {
            _appDbContext.Addresses.Add(address);
        }

        public void DeleteAddress(Guid id)
        {
            foreach (var address in _appDbContext.Addresses.ToList())
            {
                if (address.Id == id)
                {
                    _appDbContext.Addresses.Remove(address);
                }
            }
        }

        public Address GetAddress(Guid id)
        {
            foreach (var address in _appDbContext.Addresses.ToList())
            {
                if (address.Id == id)
                {
                    return address;
                }
            }
            throw new Exception("Address not found");
        }

        public IEnumerable<Address> GetAddresses()
        {
            return _appDbContext.Addresses.ToList();
        }

        public void UpdateAddress(Guid id, Address address)
        {
            throw new NotImplementedException();
        }
    }
}
