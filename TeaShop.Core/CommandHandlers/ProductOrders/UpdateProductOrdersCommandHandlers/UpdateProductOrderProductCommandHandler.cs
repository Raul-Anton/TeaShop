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
    public class UpdateProductOrderProductCommandHandler : IRequestHandler<UpdateProductOrderProductCommand>
    {
        private IUnitOfWork _unitOfWork;

        public UpdateProductOrderProductCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateProductOrderProductCommand request, CancellationToken cancellationToken)
        {
            _unitOfWork.ProductOrderRepository.UpdateProductOrderProduct(request.Id, request.Product);
            return Unit.Value;
        }
    }
}
