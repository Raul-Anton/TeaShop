using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public IEnumerable<Product> GetProducts()
        {
            return _appDbContext.Products.ToList();
        }
    }
}
