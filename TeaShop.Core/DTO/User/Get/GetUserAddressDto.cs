﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShop.Core.DTO.User.Get
{
    public class GetUserAddressDto
    {
        public string City { get; set; }

        public string Street { get; set; }

        public int Number { get; set; }
    }
}
