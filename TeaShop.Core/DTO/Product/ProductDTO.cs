using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShop.Core.DTO.Product
{
    public class ProductDTO
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        //public ProductImageDTO Image { get; set; }

        public IFormFile ImageFile { get; set; }
    }
}
