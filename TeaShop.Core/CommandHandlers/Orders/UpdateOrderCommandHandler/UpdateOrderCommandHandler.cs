using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Abstract;
using TeaShop.Core.Commands.Orders.UpdateOrderCommand;

namespace TeaShop.Core.CommandHandlers.Orders.UpdateOrderCommandHandler
{
    public class UpdateOrderCommandHandler : IRequestHandler<UpdateOrderCommand>
    {
        private IUnitOfWork _unitOfWork;

        public UpdateOrderCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
        {
            _unitOfWork.OrderRepository.UpdateOrder(request.Id, request.Order);
            _unitOfWork.SaveChanges();
            return Unit.Value;
        }
    }
}
