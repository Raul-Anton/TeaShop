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

        void UpdateProductName(Guid id, String name);

        void UpdateProductDescription(Guid id, String description);

        void UpdateProductPrice(Guid id, Double price);

        void UpdateProductQuantity(Guid id, int quantity);

        void UpdateProductProductOrderList(Guid id, List<ProductOrder> productOrderList);

        void UpdateProductImage(Guid id, Image image);


    }
}
