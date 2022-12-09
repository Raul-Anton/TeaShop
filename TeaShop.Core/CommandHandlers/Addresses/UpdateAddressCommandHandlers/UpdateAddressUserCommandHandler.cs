using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Abstract;
using TeaShop.Core.Commands.Addresses.UpdateAddressCommand;

namespace TeaShop.Core.CommandHandlers.Addresses.UpdateAddressCommandHandlers
{
    public class UpdateAddressUserCommandHandler : IRequestHandler<UpdateAddressUserCommand>
    {
        private IUnitOfWork _unitOfWork;

        public UpdateAddressUserCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateAddressUserCommand request, CancellationToken cancellationToken)
        {
            _unitOfWork.AddressRepository.UpdateAddressUser(request.Id, request.User);
            return Unit.Value;
        }
    }
}
