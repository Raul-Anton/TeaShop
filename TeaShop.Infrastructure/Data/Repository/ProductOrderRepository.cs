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

        public void DeleteProductOrder(Guid id)
        {
            foreach (var productOrder in _appDbContext.ProductOrders.ToList())
            {
                if (productOrder.Id == id)
                {
                    _appDbContext.ProductOrders.Remove(productOrder);
                }
            }
        }

        public ProductOrder GetProductOrder(Guid id)
        {
            foreach (var productOrder in _appDbContext.ProductOrders.ToList())
            {
                if (productOrder.Id == id)
                {
                    return productOrder;
                }
            }
            throw new Exception("User not found");
        }

        public IEnumerable<ProductOrder> GetProductOrders()
        {
            return _appDbContext.ProductOrders.ToList();
        }

        public void UpdateProductOrder(Guid id, ProductOrder productOrder)
        {
            throw new NotImplementedException();
        }
    }
}
