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
    public class UpdateAddressStreetCommandHandler : IRequestHandler<UpdateAddressStreetCommand>
    {
        private IUnitOfWork _unitOfWork;

        public UpdateAddressStreetCommandHandler(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateAddressStreetCommand request, CancellationToken cancellationToken)
        {
            _unitOfWork.AddressRepository.UpdateAddressStreet(request.Id, request.Street);
            return Unit.Value;
        }
    }
}
