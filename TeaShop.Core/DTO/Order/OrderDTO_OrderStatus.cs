using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Enum;

namespace TeaShop.Core.DTO.Order
{
    public class OrderDTO_OrderStatus
    {
        public Guid UserId { get; set; }

        public OrderStatus orderStatus { get; set; }
    }
}
