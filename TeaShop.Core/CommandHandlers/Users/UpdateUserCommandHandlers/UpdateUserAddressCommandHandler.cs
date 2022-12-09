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
    public class UpdateUserAddressCommandHandler : IRequestHandler<UpdateUserAddressCommand>
    {
        private IUnitOfWork _unitOfWork;

        public UpdateUserAddressCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateUserAddressCommand request, CancellationToken cancellationToken)
        {
            _unitOfWork.UserRepository.UpdateUserAddress(request.Id, request.Address);
            return Unit.Value;
        }
    }
}
