using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Abstract;
using TeaShop.Core.Commands.Users.UpdateUserCommand;

namespace TeaShop.Core.CommandHandlers.Users.UpdateUserCommandHandler
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand>
    {
        private IUnitOfWork _unitOfWork;

        public UpdateUserCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork= unitOfWork;
        }

        public async Task<Unit> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            _unitOfWork.UserRepository.UpdateUserName(request.Id, request.Name);
            return Unit.Value;
        }
    }
}
