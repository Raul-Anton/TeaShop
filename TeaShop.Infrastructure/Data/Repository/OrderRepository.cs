using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
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

        public void DeleteOrder(Guid id)
        {
            var order = _appDbContext.Orders.Include(a => a.User).Include(a => a.ProductOrders).SingleOrDefault(a => a.Id == id);

            _appDbContext.Orders.Remove(order);
        }

        public Order GetOrder(Guid id)
        {
            var order = _appDbContext.Orders.Include(a => a.User).Include(a => a.ProductOrders).SingleOrDefault(a => a.Id == id);

            if (order == null)
            {
                throw new Exception("Order not found");
            }

            return order;
        }

        public IEnumerable<Order> GetOrders()
        {
            return _appDbContext.Orders.Include(a => a.User).Include(a => a.ProductOrders);
        }

        public void UpdateOrder(Guid id, Order order)
        {
            var o = _appDbContext.Orders.Include(a => a.User).Include(a => a.ProductOrders).SingleOrDefault(a => a.Id == id);

            o.User = order.User;
        }
    }
}
