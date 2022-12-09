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
    public class UpdateUserEmailCommandHandler : IRequestHandler<UpdateUserEmailCommand>
    {
        private IUnitOfWork _unitOfWork;

        public UpdateUserEmailCommandHandler(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateUserEmailCommand request, CancellationToken cancellationToken)
        {
            _unitOfWork.UserRepository.UpdateUserEmail(request.Id, request.Email);
            return Unit.Value;
        }
    }
}
