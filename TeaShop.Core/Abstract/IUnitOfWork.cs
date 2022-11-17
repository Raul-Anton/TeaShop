using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Abstract.Repository;

namespace TeaShop.Core.Abstract
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; set; }
    }
}
