using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShop.Core.Commands.Products.UpdateProductCommands
{
    public class UpdateProductQuantityCommand : IRequest
    {
        public Guid Id { get; set; }

        public int Quantity { get; set; }
    }
}
