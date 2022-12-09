using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShop.Core.Commands.ProductOrders.UpdateProductOrderCommand
{
    public class UpdateProductOrderProductIdCommand : IRequest
    {
        public Guid Id { get; set; }

        public Guid ProductId { get; set; }
    }
}
