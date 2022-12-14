using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Abstract;
using TeaShop.Core.Commands.Orders.DeleteOrderCommand;

namespace TeaShop.Core.CommandHandlers.Orders.DeleteOrderCommandHandler
{
    public class DeleteOrderCommandHandler : IRequestHandler<DeleteOrderCommand>
    {
        private IUnitOfWork _unitOfWork;

        public DeleteOrderCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork= unitOfWork;
        }

        public async Task<Unit> Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
        {
            _unitOfWork.OrderRepository.DeleteOrder(request.Id);
            _unitOfWork.SaveChanges();
            return Unit.Value;
        }
    }
}
