using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Abstract;
using TeaShop.Core.Commands.Products.UpdateProductCommands;

namespace TeaShop.Core.CommandHandlers.Products.UpdateProductCommandHandlers
{
    public class UpdateProductQuantityCommandHandler : IRequestHandler<UpdateProductQuantityCommand>
    {
        private IUnitOfWork _unitOfWork;

        public UpdateProductQuantityCommandHandler(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateProductQuantityCommand request, CancellationToken cancellationToken)
        {
            _unitOfWork.ProductRepository.UpdateProductQuantity(request.Id, request.Quantity);
            return Unit.Value;
        }
    }
}
