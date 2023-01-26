using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Abstract;
using TeaShop.Core.Domain;
using TeaShop.Core.Queries.Orders.GetCurrentOrdersOfUserQuery;

namespace TeaShop.Core.QueryHandlers.Orders.GetCurrentOrdersOfUserQueryHandler
{
    public class GetCurrentOrdersOfUserQueryHandler: IRequestHandler<GetCurrentOrdersOfUserQuery, IEnumerable<Order>>
    {
        private IUnitOfWork _unitOfWork;

        public GetCurrentOrdersOfUserQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Order>> Handle(GetCurrentOrdersOfUserQuery request, CancellationToken cancellationToken)
        {
            return _unitOfWork.OrderRepository.GetCurrentOrdersOfUser(request.UserId);
        }
    }
}
