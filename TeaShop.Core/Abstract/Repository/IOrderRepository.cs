using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Domain;

namespace TeaShop.Core.Abstract.Repository
{
    public interface IOrderRepository
    {
        void AddOrder(Order order);

        IEnumerable<Order> GetOrders();

        Order GetOrder(Guid id);
        Order GetCurrentOrderOfUser(Guid UserId);

        void DeleteOrder(Guid id);

        void UpdateOrder(Guid id, Order order);
    }
}
