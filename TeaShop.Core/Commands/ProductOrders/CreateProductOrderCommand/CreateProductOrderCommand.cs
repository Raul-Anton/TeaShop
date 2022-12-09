using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Domain;

namespace TeaShop.Core.Commands.ProductOrders.CreateProductOrderCommand
{
    public class CreateProductOrderCommand : IRequest
    {
        public Guid Id { get; set; }

        public Guid ProductId { get; set; }

        public Product Product { get; set; }

        public Guid OrderId { get; set; }

        public Order Order { get; set; }
    }
}
