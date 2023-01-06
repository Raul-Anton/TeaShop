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
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _appDbContext;

        public ProductRepository(AppDbContext appDbContext)
        {
            _appDbContext= appDbContext;
        }

        public void AddProduct(Product product)
        {
            _appDbContext.Products.Add(product);
        }

        public void DeleteProduct(Guid id)
        {
            var product = _appDbContext.Products.Include(a => a.ProductOrders).Include(a => a.Image).SingleOrDefault(a => a.Id == id);

            _appDbContext.Products.Remove(product);
        }

        public Product GetProduct(Guid id)
        {
            var product = _appDbContext.Products.Include(a => a.ProductOrders).Include(a => a.Image).SingleOrDefault(a => a.Id == id);

            if (product == null)
            {
                throw new Exception("Product not found");
            }

            return product;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _appDbContext.Products.Include(a => a.ProductOrders).Include(a => a.Image);
        }

        public void UpdateProduct(Guid id, Product product)
        {
            var p = _appDbContext.Products.Include(a => a.Image).Include(a => a.ProductOrders).SingleOrDefault(a => a.Id == id);

            p.Description = product.Name;
            p.Description = product.Description;
            p.Price = product.Price;
            p.Quantity= product.Quantity;

            p.Image.AzurePath = product.Image.AzurePath;
        }
    }
}
