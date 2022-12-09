using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Domain;

namespace TeaShop.Core.Commands.Orders.CreateOrderCommand
{
    public class CreateOrderCommand : IRequest
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public User User { get; set; }

        public List<ProductOrder> ProductOrders { get; set; }
    }
}
