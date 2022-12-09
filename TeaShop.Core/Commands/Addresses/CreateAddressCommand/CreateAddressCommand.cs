using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Domain;

namespace TeaShop.Core.Commands.Addresses.CreateAddressCommand
{
    public class CreateAddressCommand : IRequest
    {
        public Guid Id { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public int Number { get; set; }

        public Guid UserId { get; set; }

        public User User { get; set; }
    }
}
