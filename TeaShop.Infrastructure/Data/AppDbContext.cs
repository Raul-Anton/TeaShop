using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Domain;

namespace TeaShop.Infrastructure.Data
{
    public class AppDbContext
    {
        public IList<User> Users { get; set; } = new List<User>();

        public IList<Product> Products { get; set; } = new List<Product>(); // *

        public IList<Order> Orders { get; set; } = new List<Order>();

        public IList<ProductOrder> ProductOrders { get; set; } = new List<ProductOrder>();

        public IList<Address> Addresses { get; set; } = new List<Address>();
    }
}
