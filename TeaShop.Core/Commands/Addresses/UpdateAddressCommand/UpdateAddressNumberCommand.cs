using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShop.Core.Commands.Addresses.UpdateAddressCommand
{
    public class UpdateAddressNumberCommand : IRequest
    {
        public Guid Id { get; set; }

        public int Number { get; set; }
    }
}
