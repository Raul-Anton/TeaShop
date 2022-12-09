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
    public class UpdateImageProductIdCommandHandler : IRequestHandler<UpdateImageProductIdCommand>
    {
        private IUnitOfWork _unitOfWork;

        public UpdateImageProductIdCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateImageProductIdCommand request, CancellationToken cancellationToken)
        {
            _unitOfWork.ImageRepository.UpdateImageProductId(request.Id, request.ProductId);
            return Unit.Value;
        }
    }
}
