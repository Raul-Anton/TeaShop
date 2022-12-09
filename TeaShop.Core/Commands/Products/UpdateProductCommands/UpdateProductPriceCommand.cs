﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShop.Core.Commands.Products.UpdateProductCommands
{
    public class UpdateProductPriceCommand : IRequest
    {
        public Guid Id { get; set; }
        public double Price { get; set; }
    }
}
