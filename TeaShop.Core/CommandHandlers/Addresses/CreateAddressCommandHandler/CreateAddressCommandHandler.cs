using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Abstract;
using TeaShop.Core.Commands.Addresses.CreateAddressCommand;
using TeaShop.Core.Domain;

namespace TeaShop.Core.CommandHandlers.Addresses.CreateAddressCommandHandler
{
    public class CreateAddressCommandHandler : IRequestHandler<CreateAddressCommand>
    {
        private IUnitOfWork _unitOfWork;

        public CreateAddressCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(CreateAddressCommand request, CancellationToken cancellationToken)
        {
            var address = new Address
            {
                Id = request.Id,
                City = request.City,
                Street = request.Street,
                Number = request.Number,
                UserId = request.UserId,
                User = request.User
            };
            _unitOfWork.AddressRepository.AddAddress(address);
            return Unit.Value;
        }
    }
}
