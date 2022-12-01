using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public IEnumerable<Address> GetAddresses()
        {
            return _appDbContext.Addresses.ToList();
        }
    }
}
