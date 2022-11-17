using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Domain;

namespace TeaShop.Infrastructure.Data
{
    public class AppDbContext
    {
        public IList<User> Users { get; set; } = new List<User>();
    }
}
