using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Abstract;
using TeaShop.Core.Commands.Images.UpdateImageCommand;

namespace TeaShop.Core.CommandHandlers.Images.UpdateImageCommandHandlers
{
    public class UpdateImageProductCommandHandler : IRequestHandler<UpdateImageProductCommand>
    {
        private IUnitOfWork _unitOfWork;

        public UpdateImageProductCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateImageProductCommand request, CancellationToken cancellationToken)
        {
            _unitOfWork.ImageRepository.UpdateImageProduct(request.Id, request.Product);
            return Unit.Value;
        }
    }
}
