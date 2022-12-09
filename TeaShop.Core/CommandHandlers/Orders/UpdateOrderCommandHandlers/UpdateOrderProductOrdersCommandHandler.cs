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
    public class UpdateOrderProductOrdersCommandHandler : IRequestHandler<UpdateOrderProductOrdersCommand>
    {
        private IUnitOfWork _unitOfWork;

        public UpdateOrderProductOrdersCommandHandler(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateOrderProductOrdersCommand request, CancellationToken cancellationToken)
        {
            _unitOfWork.OrderRepository.UpdateOrderProductOrders(request.Id, request.ProductOrders);
            return Unit.Value;
        }
    }
}
