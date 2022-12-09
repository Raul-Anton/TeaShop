using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Domain;

namespace TeaShop.Core.Commands.Products.UpdateProductCommands
{
    public class UpdateProductProductOrdersCommand : IRequest
    {
        public Guid Id { get; set; }

        public List<ProductOrder> ProductOrders { get; set; }
    }
}
