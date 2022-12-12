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
    public class UpdateOrderCommandHandler : IRequestHandler<UpdateOrderUserCommand>
    {
        private IUnitOfWork _unitOfWork;

        public UpdateOrderCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateOrderUserCommand request, CancellationToken cancellationToken)
        {
            _unitOfWork.OrderRepository.UpdateOrderUser(request.Id, request.User);
            return Unit.Value;
        }
    }
}
