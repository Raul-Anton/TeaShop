using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Abstract.Repository;

namespace TeaShop.Infrastructure.Data.Repository
{
    public class ImageRepository : IImageRepository
    {
        private readonly AppDbContext _appDbContext;

        public ImageRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
