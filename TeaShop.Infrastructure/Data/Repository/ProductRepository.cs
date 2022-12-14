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
            foreach (var product in _appDbContext.Products.ToList())
            {
                if (product.Id == id)
                {
                    _appDbContext.Products.Remove(product);
                }
            }
        }

        public Product GetProduct(Guid id)
        {
            foreach (var product in _appDbContext.Products.ToList())
            {
                if (product.Id == id)
                {
                    return product;
                }
            }
            throw new Exception("Product not found");
        }

        public IEnumerable<Product> GetProducts()
        {
            return _appDbContext.Products.ToList();
        }

        public void UpdateProduct(Guid id, Product product)
        {
            throw new NotImplementedException();
        }
    }
}
