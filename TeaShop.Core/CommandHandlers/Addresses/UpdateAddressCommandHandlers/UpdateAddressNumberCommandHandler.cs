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
    public class UpdateAddressNumberCommandHandler : IRequestHandler<UpdateAddressNumberCommand>
    {
        private IUnitOfWork _unitOfWork;

        public UpdateAddressNumberCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateAddressNumberCommand request, CancellationToken cancellationToken)
        {
            _unitOfWork.AddressRepository.UpdateAddressNumber(request.Id, request.Number);
            return Unit.Value;
        }
    }
}
