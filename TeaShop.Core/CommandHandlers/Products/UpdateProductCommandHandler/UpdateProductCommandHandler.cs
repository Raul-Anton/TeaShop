using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Abstract;
using TeaShop.Core.Commands.Products.UpdateProductCommand;

namespace TeaShop.Core.CommandHandlers.Products.UpdateProductCommandHandler
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private IUnitOfWork _unitOfWork;

        public UpdateProductCommandHandler(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            _unitOfWork.ProductRepository.UpdateProductName(request.Id, request.Name);
            return Unit.Value;
        }
    }
}
