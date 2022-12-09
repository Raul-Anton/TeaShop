using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Abstract;
using TeaShop.Core.Commands.Users.UpdateUserCommands;

namespace TeaShop.Core.CommandHandlers.Users.UpdateUserCommandHandlers
{
    public class UpdateUserPasswordCommandHandler : IRequestHandler<UpdateUserPasswordCommand>
    {
        private IUnitOfWork _unitOfWork;

        public UpdateUserPasswordCommandHandler(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateUserPasswordCommand request, CancellationToken cancellationToken)
        {
            _unitOfWork.UserRepository.UpdateUserPassword(request.Id, request.Password);
            return Unit.Value;
        }
    }
}
