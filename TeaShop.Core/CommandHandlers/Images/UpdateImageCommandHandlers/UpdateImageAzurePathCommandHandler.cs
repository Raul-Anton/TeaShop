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
    public class UpdateImageAzurePathCommandHandler : IRequestHandler<UpdateImageAzurePathCommand>
    {
        private IUnitOfWork _unitOfWork;

        public UpdateImageAzurePathCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateImageAzurePathCommand request, CancellationToken cancellationToken)
        {
            _unitOfWork.ImageRepository.UpdateImageAzurePath(request.Id, request.AzurePath);
            return Unit.Value;
        }
    }
}
