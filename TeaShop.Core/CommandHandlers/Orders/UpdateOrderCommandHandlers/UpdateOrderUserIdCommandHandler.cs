using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Abstract;
using TeaShop.Core.Commands.Orders.UpdateOrderCommand;

namespace TeaShop.Core.CommandHandlers.Orders.UpdateOrderCommandHandlers
{
    public class UpdateOrderUserIdCommandHandler : IRequestHandler<UpdateOrderUserIdCommand>
    {
        private IUnitOfWork _unitOfWork;

        public UpdateOrderUserIdCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateOrderUserIdCommand request, CancellationToken cancellationToken)
        {
            _unitOfWork.OrderRepository.UpdateOrderUserId(request.Id, request.UserId);
            return Unit.Value;
        }
    }
}
