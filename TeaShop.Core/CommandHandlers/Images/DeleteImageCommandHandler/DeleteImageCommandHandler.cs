using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Abstract;
using TeaShop.Core.Commands.Images.DeleteImageCommand;

namespace TeaShop.Core.CommandHandlers.Images.DeleteImageCommandHandler
{
    public class DeleteImageCommandHandler : IRequestHandler<DeleteImageCommand>
    {
        private IUnitOfWork _unitOfWork;

        public DeleteImageCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(DeleteImageCommand request, CancellationToken cancellationToken)
        {
            _unitOfWork.ImageRepository.DeleteImage(request.Id);
            _unitOfWork.SaveChanges();
            return Unit.Value;
        }
    }
}
