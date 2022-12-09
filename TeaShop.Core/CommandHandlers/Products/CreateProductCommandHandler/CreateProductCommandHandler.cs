using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Abstract;
using TeaShop.Core.Commands.Products.CreateProductCommand;
using TeaShop.Core.Domain;

namespace TeaShop.Core.CommandHandlers.Products.CreateProductCommandHandler
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
    {
        private IUnitOfWork _unitOfWork;

        public CreateProductCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product
            {
                Id = request.Id,
                Name = request.Name,
                Description = request.Description,
                Price = request.Price,
                Quantity = request.Quantity,
                ProductOrders = request.ProductOrders,
                Image = request.Image
            };
            _unitOfWork.ProductRepository.AddProduct(product);
            return Unit.Value;
        }
    }
}
