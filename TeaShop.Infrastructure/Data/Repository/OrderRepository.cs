using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Abstract.Repository;
using TeaShop.Core.Domain;

namespace TeaShop.Infrastructure.Data.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;

        public OrderRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void AddOrder(Order order)
        {
            _appDbContext.Orders.Add(order);
        }

        public IEnumerable<Order> GetOrders()
        {
            return _appDbContext.Orders.ToList();
        }
    }
}
