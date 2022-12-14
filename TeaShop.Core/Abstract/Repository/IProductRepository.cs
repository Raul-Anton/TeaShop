using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Domain;

namespace TeaShop.Core.Abstract.Repository
{
    public interface IProductRepository
    {
        void AddProduct(Product product);

        IEnumerable<Product> GetProducts();

        Product GetProduct(Guid id);

        void DeleteProduct(Guid id);

        void UpdateProduct(Guid id, Product product);
    }
}
