using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShop.Core.Commands.Images.UpdateImageCommand
{
    public class UpdateImageCommand : IRequest
    {
        public Guid Id { get; set; }

        public string AzurePath { get; set; }
    }
}
