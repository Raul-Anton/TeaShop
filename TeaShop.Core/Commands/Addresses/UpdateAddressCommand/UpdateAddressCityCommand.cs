using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShop.Core.Commands.Addresses.UpdateAddressCommand
{
    public class UpdateAddressCityCommand : IRequest
    {
        public Guid Id { get; set; }

        public string City { get; set; }
    }
}
