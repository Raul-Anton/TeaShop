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

        public void UpdateAddressCity(Guid id, string city)
        {
            foreach (var address in _appDbContext.Addresses.ToList())
            {
                if (address.Id == id)
                {
                    address.City = city;
                }
            }
        }

        public void UpdateAddressNumber(Guid id, int number)
        {
            foreach (var address in _appDbContext.Addresses.ToList())
            {
                if (address.Id == id)
                {
                    address.Number = number;
                }
            }
        }

        public void UpdateAddressStreet(Guid id, string street)
        {
            foreach (var address in _appDbContext.Addresses.ToList())
            {
                if (address.Id == id)
                {
                    address.Street = street;
                }
            }
        }

        public void UpdateAddressUser(Guid id, User user)
        {
            foreach (var address in _appDbContext.Addresses.ToList())
            {
                if (address.Id == id)
                {
                    address.User = user;
                }
            }
        }

        public void UpdateAddressUserId(Guid id, Guid userId)
        {
            foreach (var address in _appDbContext.Addresses.ToList())
            {
                if (address.Id == id)
                {
                    address.UserId = userId;
                }
            }
        }
    }
}
