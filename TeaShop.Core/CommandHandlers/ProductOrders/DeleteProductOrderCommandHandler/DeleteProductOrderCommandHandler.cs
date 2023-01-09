using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Abstract;
using TeaShop.Core.Commands.ProductOrders.DeleteProductOrderCommand;

namespace TeaShop.Core.CommandHandlers.ProductOrders.DeleteProductOrderCommandHandler
{
    public class DeleteProductOrderCommandHandler : IRequestHandler<DeleteProductOrderCommand>
    {
        private IUnitOfWork _unitOfWork;

        public DeleteProductOrderCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(DeleteProductOrderCommand request, CancellationToken cancellationToken)
        {
            _unitOfWork.ProductOrderRepository.DeleteProductOrder(request.Id);
            _unitOfWork.SaveChanges();
            return Unit.Value;
        }
    }
}
