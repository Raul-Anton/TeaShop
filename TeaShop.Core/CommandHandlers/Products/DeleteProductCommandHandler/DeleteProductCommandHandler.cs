using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Abstract;
using TeaShop.Core.Commands.Products.DeleteProductCommand;

namespace TeaShop.Core.CommandHandlers.Products.DeleteProductCommandHandler
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand>
    {
        private IUnitOfWork _unitOfWork;

        public DeleteProductCommandHandler(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            _unitOfWork.ProductRepository.DeleteProduct(request.Id);
            _unitOfWork.SaveChanges();
            return Unit.Value;
        }
    }
}
