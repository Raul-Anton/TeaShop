using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShop.Core.Commands.Images.DeleteImageCommand
{
    public class DeleteImageCommand : IRequest
    {
        public Guid Id { get; set; }

    }
}
