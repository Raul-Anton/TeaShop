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
    public class UpdateProductImageCommandHandler : IRequestHandler<UpdateProductImageCommand>
    {
        private IUnitOfWork _unitOfWork;

        public UpdateProductImageCommandHandler(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateProductImageCommand request, CancellationToken cancellationToken)
        {
            _unitOfWork.ProductRepository.UpdateProductImage(request.Id, request.Image);
            return Unit.Value;
        }
    }
}
