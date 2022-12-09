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
    public class UpdateProductOrderOrderCommandHandler : IRequestHandler<UpdateProductOrderOrderCommand>
    {
        private IUnitOfWork _unitOfWork;

        public UpdateProductOrderOrderCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateProductOrderOrderCommand request, CancellationToken cancellationToken)
        {
            _unitOfWork.ProductOrderRepository.UpdateProductOrderOrder(request.Id, request.Order);
            return Unit.Value;
        }
    }
}
