using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Abstract;
using TeaShop.Core.Commands.Orders.CreateOrderCommand;
using TeaShop.Core.Domain;

namespace TeaShop.Core.CommandHandlers.Orders.CreateOrderCommandHandler
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand>
    {
        private IUnitOfWork _unitOfWork;

        public CreateOrderCommandHandler(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var order = new Order
            {
                Id = request.Id,
                UserId = request.UserId,
                User = request.User,
                orderStatus = Enum.OrderStatus.InProgress,
                ProductOrders = request.ProductOrders,
            };
            _unitOfWork.OrderRepository.AddOrder(order);
            _unitOfWork.SaveChanges();
            return Unit.Value;
        }
    }
}
