using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.DTO.ProductOrder;
using TeaShop.Core.DTO.User;
using TeaShop.Core.Enum;

namespace TeaShop.Core.DTO.Order
{
    public class OrderDTO
    {
        public Guid UserId { get; set; }
    }
}
