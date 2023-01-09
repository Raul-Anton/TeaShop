using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShop.Core.DTO.ProductOrder
{
    public class ProductOrderDTO
    {
        public Guid ProductId { get; set; }

        public Guid OrderId { get; set; }
    }
}
