﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShop.Core.Domain
{
    public class Image
    {
        public Guid Id { get; set; }

        public string AzurePath { get; set; }

        public Guid ProductId { get; set; }

        public Product Product { get; set; }
    }
}
