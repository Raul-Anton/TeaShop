using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShop.Core.Commands.Users.UpdateUserCommands
{
    public class UpdateUserEmailCommand : IRequest
    {
        public Guid Id { get; set; }

        public string Email { get; set; }
    }
}
