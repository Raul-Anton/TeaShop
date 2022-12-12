﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShop.Core.Commands.Users.UpdateUserCommand
{
    public class UpdateUserCommand : IRequest
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
