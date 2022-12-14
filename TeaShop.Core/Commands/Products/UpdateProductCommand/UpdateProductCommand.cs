using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Domain;

namespace TeaShop.Core.Commands.Products.UpdateProductCommand
{
    public class UpdateProductCommand : IRequest
    {
        public Guid Id { get; set; }

        public Product Product { get; set; }
    }
}
