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

        private IProductRepository _productRepository;

        private IOrderRepository _orderRepository;

        private IProductOrderRepository _productOrderRepository;

        private IAddressRepository _addressRepository;

        private IImageRepository _imageRepository;

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

        public IProductRepository ProductRepository // *
        {
            get
            {
                if (_productRepository == null)
                    _productRepository = new ProductRepository(_appDbContext);
                return _productRepository;
            }
            set
            {
                _productRepository = value;
            }
        }

        public IOrderRepository OrderRepository // *
        {
            get
            {
                if (_orderRepository == null)
                    _orderRepository = new OrderRepository(_appDbContext);
                return _orderRepository;
            }
            set
            {
                _orderRepository = value;
            }
        }

        public IProductOrderRepository ProductOrderRepository
        {
            get
            {
                if (_productOrderRepository == null)
                    _productOrderRepository = new ProductOrderRepository(_appDbContext);
                return _productOrderRepository;
            }
            set
            {
                _productOrderRepository = value;
            }
        }

        public IAddressRepository AddressRepository // *
        {
            get
            {
                if (_addressRepository == null)
                    _addressRepository = new AddressRepository(_appDbContext);
                return _addressRepository;
            }
            set
            {
                _addressRepository = value;
            }
        }

        public IImageRepository ImageRepository 
        {
            get
            {
                if (_imageRepository == null)
                    _imageRepository = new ImageRepository(_appDbContext);
                return _imageRepository;
            }
            set
            {
                _imageRepository = value;
            }
        }
    }
}
