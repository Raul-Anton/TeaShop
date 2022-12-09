using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShop.Core.Commands.Addresses.DeleteAddressCommand
{
    public class DeleteAddressCommand : IRequest
    {
        public Guid Id { get; set; }

    }
}
