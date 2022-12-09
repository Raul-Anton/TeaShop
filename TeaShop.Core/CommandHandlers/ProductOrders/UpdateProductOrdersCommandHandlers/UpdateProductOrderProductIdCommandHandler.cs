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
    public class UpdateProductOrderProductIdCommandHandler : IRequestHandler<UpdateProductOrderProductIdCommand>
    {
        private IUnitOfWork _unitOfWork;

        public UpdateProductOrderProductIdCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

 /*       public async Task<Unit> Handle(UpdateProductOrderProductIdCommandHandler request, CancellationToken cancellationToken)
        {
            _unitOfWork.ProductOrderRepository.UpdateProductOrderProductId(request.Id, request.ProductId);
            return Unit.Value;
        }
 */

        public Task<Unit> Handle(UpdateProductOrderProductIdCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
