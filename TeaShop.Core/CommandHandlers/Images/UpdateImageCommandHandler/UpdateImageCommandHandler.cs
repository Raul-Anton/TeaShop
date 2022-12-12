using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Abstract;
using TeaShop.Core.Commands.Images.UpdateImageCommand;

namespace TeaShop.Core.CommandHandlers.Images.UpdateImageCommandHandler
{
    public class UpdateImageCommandHandler : IRequestHandler<UpdateImageCommand>
    {
        private IUnitOfWork _unitOfWork;

        public UpdateImageCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateImageCommand request, CancellationToken cancellationToken)
        {
            _unitOfWork.ImageRepository.UpdateImageAzurePath(request.Id, request.AzurePath);
            return Unit.Value;
        }
    }
}
