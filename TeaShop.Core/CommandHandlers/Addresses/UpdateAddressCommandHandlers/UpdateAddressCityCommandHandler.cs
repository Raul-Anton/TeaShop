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
    public class UpdateAddressCityCommandHandler : IRequestHandler<UpdateAddressCityCommand>
    {
        private IUnitOfWork _unitOfWork;

        public UpdateAddressCityCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateAddressCityCommand request, CancellationToken cancellationToken)
        {
            _unitOfWork.AddressRepository.UpdateAddressCity(request.Id, request.City);
            return Unit.Value;
        }
    }
}
