﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShop.Core.Commands.Products
{
    public class CreateProductCommand : IRequest
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
