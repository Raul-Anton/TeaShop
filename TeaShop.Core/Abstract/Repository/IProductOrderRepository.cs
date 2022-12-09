using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Domain;

namespace TeaShop.Core.Abstract.Repository
{
    public interface IProductOrderRepository
    {
        void AddProduct(ProductOrder productOrder);

        IEnumerable<ProductOrder> GetProductOrders();

        ProductOrder GetProductOrder(Guid id);

        void DeleteProductOrder(Guid id);

        void UpdateProductOrderProductId(Guid id, Guid productId);

        void UpdateProductOrderProduct(Guid id, Product product);

        void UpdateProductOrderOrderId(Guid id, Guid orderId);

        void UpdateProductOrderOrder(Guid id, Order order);
    }
}
