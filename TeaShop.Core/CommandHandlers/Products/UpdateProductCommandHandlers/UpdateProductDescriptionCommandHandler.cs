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
    public class UpdateProductDescriptionCommandHandler : IRequestHandler<UpdateProductDescriptionCommand>
    {
        private IUnitOfWork _unitOfWork;

        public UpdateProductDescriptionCommandHandler(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateProductDescriptionCommand request, CancellationToken cancellationToken)
        {
            _unitOfWork.ProductRepository.UpdateProductDescription(request.Id, request.Description);
            return Unit.Value;
        }
    }
}
