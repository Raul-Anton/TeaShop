using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Domain;

namespace TeaShop.Core.Commands.Images.CreateImageCommand
{
    public class CreateImageCommand : IRequest
    {
        public Guid Id { get; set; }

        public string AzurePath { get; set; }

        public Guid ProductId { get; set; }

        public Product Product { get; set; }
    }
}
