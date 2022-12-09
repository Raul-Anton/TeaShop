using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Domain;

namespace TeaShop.Core.Commands.Users.DeleteUserCommand
{
    public class DeleteUserCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
