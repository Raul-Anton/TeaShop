using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Abstract;
using TeaShop.Core.Commands.ProductOrders.UpdateProductOrderCommand;

namespace TeaShop.Core.CommandHandlers.ProductOrders.UpdateProductOrdersCommandHandlers
{
    public class UpdateProductOrderOrderIdCommandHandler : IRequestHandler<UpdateProductOrderOrderIdCommand>
    {
        private IUnitOfWork _unitOfWork;

        public UpdateProductOrderOrderIdCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateProductOrderOrderIdCommand request, CancellationToken cancellationToken)
        {
            _unitOfWork.ProductOrderRepository.UpdateProductOrderOrderId(request.Id, request.OrderId);
            return Unit.Value;
        }
    }
}
