using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShop.Core.Commands.Products.DeleteProductCommand
{
    public class DeleteProductCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
