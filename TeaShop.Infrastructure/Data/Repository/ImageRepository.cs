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
    public class ImageRepository : IImageRepository
    {
        private readonly AppDbContext _appDbContext;

        public ImageRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void AddImage(Image image)
        {
            _appDbContext.Images.Add(image);
        }

        public void DeleteImage(Guid id)
        {
            foreach (var image in _appDbContext.Images.ToList())
            {
                if (image.Id == id)
                {
                    _appDbContext.Images.Remove(image);
                }
            }
        }

        public Image GetImage(Guid id)
        {
            foreach (var image in _appDbContext.Images.ToList())
            {
                if (image.Id == id)
                {
                    return image;
                }
            }
            throw new Exception("Image not found");
        }

        public IEnumerable<Image> GetImages()
        {
            return _appDbContext.Images;
        }

        public void UpdateImageAzurePath(Guid id, string azurePath)
        {
            foreach (var image in _appDbContext.Images.ToList())
            {
                if (image.Id == id)
                {
                    image.AzurePath = azurePath;
                }
            }
        }

        public void UpdateImageProduct(Guid id, Product product)
        {
            foreach (var image in _appDbContext.Images.ToList())
            {
                if (image.Id == id)
                {
                    image.Product = product;
                }
            }
        }

        public void UpdateImageProductId(Guid id, Guid productId)
        {
            foreach (var image in _appDbContext.Images.ToList())
            {
                if (image.Id == id)
                {
                    image.ProductId = productId;
                }
            }
        }
    }
}
