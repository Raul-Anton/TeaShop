using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Domain;

namespace TeaShop.Core.Commands.Addresses.UpdateAddressCommand
{
    public class UpdateAddressUserIdCommand : IRequest
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }
    }
}
