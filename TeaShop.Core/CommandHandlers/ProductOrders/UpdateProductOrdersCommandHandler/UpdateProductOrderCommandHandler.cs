using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Abstract;
using TeaShop.Core.Commands.ProductOrders.UpdateProductOrderCommand;

namespace TeaShop.Core.CommandHandlers.ProductOrders.UpdateProductOrdersCommandHandler
{
    public class UpdateProductOrderCommandHandler : IRequestHandler<UpdateProductOrderCommand>
    {
        private IUnitOfWork _unitOfWork;

        public UpdateProductOrderCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateProductOrderCommand request, CancellationToken cancellationToken)
        {
            _unitOfWork.ProductOrderRepository.UpdateProductOrderOrder(request.Id, request.Order);
            return Unit.Value;
        }
    }
}
