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
    public class UpdateUserNameCommandHandler : IRequestHandler<UpdateUserNameCommand>
    {
        private IUnitOfWork _unitOfWork;

        public UpdateUserNameCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork= unitOfWork;
        }

        public async Task<Unit> Handle(UpdateUserNameCommand request, CancellationToken cancellationToken)
        {
            _unitOfWork.UserRepository.UpdateUserName(request.Id, request.Name);
            return Unit.Value;
        }
    }
}
