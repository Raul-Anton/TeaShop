using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Abstract;
using TeaShop.Core.Commands.Images.CreateImageCommand;
using TeaShop.Core.Domain;

namespace TeaShop.Core.CommandHandlers.Images.CreateImageCommandHandler
{
    public  class CreateImageCommandHandler : IRequestHandler<CreateImageCommand>
    {
        private IUnitOfWork _unitOfWork;

        public CreateImageCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(CreateImageCommand request, CancellationToken cancellationToken)
        {
            var image = new Image
            {
                Id = request.Id,
                AzurePath = request.AzurePath,
                ProductId = request.ProductId,
                Product = request.Product
            };
            _unitOfWork.ImageRepository.AddImage(image);
            _unitOfWork.SaveChanges();
            return Unit.Value;
        }
    }
}
