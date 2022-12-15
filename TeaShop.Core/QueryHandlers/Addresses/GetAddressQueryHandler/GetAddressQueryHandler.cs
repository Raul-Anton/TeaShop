using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Abstract;
using TeaShop.Core.Domain;
using TeaShop.Core.Queries.Addresses.GetAddressQuery;

namespace TeaShop.Core.QueryHandlers.Addresses.GetAddressQueryHandler
{
    public class GetAddressQueryHandler : IRequestHandler<GetAddressQuery, Address>
    {
        private IUnitOfWork _unitOfWork;

        public GetAddressQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Address> Handle(GetAddressQuery request, CancellationToken cancellationToken)
        {
            return _unitOfWork.AddressRepository.GetAddress(request.Id);
        }
    }
}
