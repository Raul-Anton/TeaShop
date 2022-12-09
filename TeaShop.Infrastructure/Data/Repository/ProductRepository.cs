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

        public void UpdateProductDescription(Guid id, string description)
        {
            foreach (var product in _appDbContext.Products.ToList())
            {
                if (product.Id == id)
                {
                    product.Description = description;
                }
            }
        }

        public void UpdateProductImage(Guid id, Image image)
        {
            foreach (var product in _appDbContext.Products.ToList())
            {
                if (product.Id == id)
                {
                    product.Image = image;
                }
            }
        }

        public void UpdateProductName(Guid id, string name)
        {
            foreach (var product in _appDbContext.Products.ToList())
            {
                if (product.Id == id)
                {
                    product.Name = name;
                }
            }
        }

        public void UpdateProductPrice(Guid id, double price)
        {
            foreach (var product in _appDbContext.Products.ToList())
            {
                if (product.Id == id)
                {
                    product.Price = price;
                }
            }
        }

        public void UpdateProductProductOrderList(Guid id, List<ProductOrder> productOrderList)
        {
            foreach (var product in _appDbContext.Products.ToList())
            {
                if (product.Id == id)
                {
                    product.ProductOrders = productOrderList;
                }
            }
        }

        public void UpdateProductQuantity(Guid id, int quantity)
        {
            foreach (var product in _appDbContext.Products.ToList())
            {
                if (product.Id == id)
                {
                    product.Quantity = quantity;
                }
            }
        }
    }
}
