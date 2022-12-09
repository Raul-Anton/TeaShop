using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShop.Core.Commands.ProductOrders.DeleteProductOrderCommand
{
    public class DeleteProductOrderCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
