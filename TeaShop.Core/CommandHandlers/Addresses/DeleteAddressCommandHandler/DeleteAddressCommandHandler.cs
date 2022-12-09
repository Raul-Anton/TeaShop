using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Abstract;
using TeaShop.Core.Commands.Addresses.DeleteAddressCommand;

namespace TeaShop.Core.CommandHandlers.Addresses.DeleteAddressCommandHandler
{
    public class DeleteAddressCommandHandler : IRequestHandler<DeleteAddressCommand>
    {
        private IUnitOfWork _unitOfWork;

        public DeleteAddressCommandHandler(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(DeleteAddressCommand request, CancellationToken cancellationToken)
        {
            _unitOfWork.AddressRepository.DeleteAddress(request.Id);
            return Unit.Value;
        }
    }
}
