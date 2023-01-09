using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.DTO.User;

namespace TeaShop.Core.DTO.Order
{
    public class OrderDTO_Id
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }
    }
}
