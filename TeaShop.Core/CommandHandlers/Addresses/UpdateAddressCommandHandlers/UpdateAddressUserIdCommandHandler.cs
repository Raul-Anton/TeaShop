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
    public class UpdateAddressUserIdCommandHandler : IRequestHandler<UpdateAddressUserIdCommand>
    {
        private IUnitOfWork _unitOfWork;

        public UpdateAddressUserIdCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateAddressUserIdCommand request, CancellationToken cancellationToken)
        {
            _unitOfWork.AddressRepository.UpdateAddressUserId(request.Id, request.UserId);
            return Unit.Value;
        }
    }
}
