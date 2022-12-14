using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Domain;

namespace TeaShop.Core.Abstract.Repository
{
    public interface IImageRepository
    {
        void AddImage(Image image);

        IEnumerable<Image> GetImages();

        Image GetImage(Guid id);

        void DeleteImage(Guid id);

        void UpdateImage(Guid id, Image image);
    }
}
