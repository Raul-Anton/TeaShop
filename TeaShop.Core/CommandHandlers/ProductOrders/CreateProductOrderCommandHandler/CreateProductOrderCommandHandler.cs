using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Abstract;
using TeaShop.Core.Commands.ProductOrders.CreateProductOrderCommand;
using TeaShop.Core.Domain;

namespace TeaShop.Core.CommandHandlers.ProductOrders.CreateProductOrderCommandHandler
{
    public class CreateProductOrderCommandHandler : IRequestHandler<CreateProductOrderCommand>
    {
        private IUnitOfWork _unitOfWork;

        public CreateProductOrderCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(CreateProductOrderCommand request, CancellationToken cancellationToken)
        {
            var productOrder = new ProductOrder
            {
                Id = request.Id,
                ProductId = request.ProductId,
                Product = request.Product,
                OrderId = request.OrderId,
                Order = request.Order
            };
            _unitOfWork.ProductOrderRepository.AddProduct(productOrder);
            return Unit.Value;
        }
    }
}
