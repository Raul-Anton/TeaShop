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
    public class UpdateProductNameCommandHandler : IRequestHandler<UpdateProductNameCommand>
    {
        private IUnitOfWork _unitOfWork;

        public UpdateProductNameCommandHandler(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateProductNameCommand request, CancellationToken cancellationToken)
        {
            _unitOfWork.ProductRepository.UpdateProductName(request.Id, request.Name);
            return Unit.Value;
        }
    }
}
