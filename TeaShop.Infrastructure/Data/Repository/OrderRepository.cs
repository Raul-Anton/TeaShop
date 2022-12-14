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
            foreach (var order in _appDbContext.Orders.ToList())
            {
                if (order.Id == id)
                {
                    _appDbContext.Orders.Remove(order);
                }
            }
        }

        public Order GetOrder(Guid id)
        {
            foreach (var order in _appDbContext.Orders.ToList())
            {
                if (order.Id == id)
                {
                    return order;
                }
            }
            throw new Exception("Order not found");
        }

        public IEnumerable<Order> GetOrders()
        {
            return _appDbContext.Orders.ToList();
        }

        public void UpdateOrder(Guid id, Order order)
        {
            throw new NotImplementedException();
        }
    }
}
