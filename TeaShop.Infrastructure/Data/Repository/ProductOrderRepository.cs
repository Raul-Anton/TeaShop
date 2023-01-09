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
            var productOrder = _appDbContext.ProductOrders.Include(a => a.Product).Include(a => a.Order).SingleOrDefault(a => a.Id == id);

            _appDbContext.ProductOrders.Remove(productOrder);
        }

        public ProductOrder GetProductOrder(Guid id)
        {
            var productOrder = _appDbContext.ProductOrders.Include(a => a.Product).Include(a => a.Order).SingleOrDefault(a => a.Id == id);

            if(productOrder== null) { throw new Exception("ProductOrder not found"); }

            return productOrder;

        }

        public IEnumerable<ProductOrder> GetProductOrders()
        {
            return _appDbContext.ProductOrders.Include(a => a.Product).Include(a => a.Order);
        }

        public void UpdateProductOrder(Guid id, ProductOrder productOrder)
        {
            var pO = _appDbContext.ProductOrders.Include(a => a.Product).Include(a => a.Order).SingleOrDefault(a => a.Id == id);

            pO.Product = productOrder.Product;
            pO.Order = productOrder.Order;
        }
    }
}
