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
    public class UpdateProductPriceCommandHandler : IRequestHandler<UpdateProductPriceCommand>
    {
        private IUnitOfWork _unitOfWork;

        public UpdateProductPriceCommandHandler(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateProductPriceCommand request, CancellationToken cancellationToken)
        {
            _unitOfWork.ProductRepository.UpdateProductPrice(request.Id, request.Price);
            return Unit.Value;
        }
    }
}
