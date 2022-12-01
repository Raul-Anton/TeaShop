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
        void AddProduct(ProductOrder productOrder); // *

        IEnumerable<ProductOrder> GetProductOrders(); // *
    }
}
