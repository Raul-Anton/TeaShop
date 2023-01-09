using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShop.Core.DTO.ProductOrder
{
    public class ProductOrderDTO_Id
    {
        public Guid Id { get; set; }

        public Guid ProductId { get; set; }

        public Guid OrderId { get; set; }
    }
}
