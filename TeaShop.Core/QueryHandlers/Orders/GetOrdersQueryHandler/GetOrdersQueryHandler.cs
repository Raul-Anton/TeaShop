using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Abstract;
using TeaShop.Core.Domain;
using TeaShop.Core.Queries.Orders.GetOrdersQuery;

namespace TeaShop.Core.QueryHandlers.Orders.GetOrdersQueryHandler
{
    public class GetOrdersQueryHandler : IRequestHandler<GetOrdersQuery, IEnumerable<Order>>
    {
        private IUnitOfWork _unitOfWork;

        public GetOrdersQueryHandler(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Order>> Handle(GetOrdersQuery request, CancellationToken cancellationToken)
        {
            return _unitOfWork.OrderRepository.GetOrders();
        }
    }
}
