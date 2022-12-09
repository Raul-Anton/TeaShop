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
    public class UpdateProductProductOrdersCommandHandler : IRequestHandler<UpdateProductProductOrdersCommand>
    {
        private IUnitOfWork _unitOfWork;

        public UpdateProductProductOrdersCommandHandler(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateProductProductOrdersCommand request, CancellationToken cancellationToken)
        {
            _unitOfWork.ProductRepository.UpdateProductProductOrderList(request.Id, request.ProductOrders);
            return Unit.Value;
        }
    }
}
