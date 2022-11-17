using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Abstract;
using TeaShop.Core.Abstract.Repository;
using TeaShop.Infrastructure.Data.Repository;

namespace TeaShop.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;
        
        private IUserRepository _userRepository;

        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IUserRepository UserRepository 
        { 
            get
            {
                if (_userRepository == null)
                    _userRepository = new UserRepository(_appDbContext);
                return _userRepository;
            }
            set
            {
                _userRepository = value;
            }
        }

    }
}
