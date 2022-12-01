using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Abstract.Repository;
using TeaShop.Core.Domain;

namespace TeaShop.Infrastructure.Data.Repository
{
    public class ProductOrderRepository : IProductOrderRepository
    {
        private readonly AppDbContext _appDbContext;

        public ProductOrderRepository(AppDbContext appDbContext)
        {
            _appDbContext= appDbContext;
        }

        public void AddProduct(ProductOrder productOrder)
        {
            _appDbContext.ProductOrders.Add(productOrder);
        }

        public IEnumerable<ProductOrder> GetProductOrders()
        {
            return _appDbContext.ProductOrders.ToList();
        }
    }
}
