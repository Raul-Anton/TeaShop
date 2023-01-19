using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Domain;
using TeaShop.Core.Enum;

namespace TeaShop.Core.Commands.Orders.UpdateOrderCommand
{
    public class UpdateOrderCommand : IRequest
    {
        public Guid Id { get; set; }

        public Order Order { get; set; }
    }
}
