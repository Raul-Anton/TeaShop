using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShop.Core.Commands.Users.UpdateUserCommands
{
    public class UpdateUserPasswordCommand: IRequest
    {
        public Guid Id { get; set; }

        public string Password { get; set; }
    }
}
