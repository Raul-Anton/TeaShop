using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Abstract;
using TeaShop.Core.Domain;
using TeaShop.Core.Queries.Addresses.GetAddressesQuery;

namespace TeaShop.Core.QueryHandlers.Addresses.GetAddtressesQueryHandler
{
    public  class GetAddressesQueryHandler : IRequestHandler<GetAddressesQuery, IEnumerable<Address>>
    {
        private IUnitOfWork _unitOfWork;

        public GetAddressesQueryHandler(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Address>> Handle(GetAddressesQuery request, CancellationToken cancellationToken)
        {
            return _unitOfWork.AddressRepository.GetAddresses();
        }
    }
}
