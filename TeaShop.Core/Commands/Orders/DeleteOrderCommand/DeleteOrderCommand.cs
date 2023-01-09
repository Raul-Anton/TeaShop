using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShop.Core.Commands.Orders.DeleteOrderCommand
{
    public class DeleteOrderCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
