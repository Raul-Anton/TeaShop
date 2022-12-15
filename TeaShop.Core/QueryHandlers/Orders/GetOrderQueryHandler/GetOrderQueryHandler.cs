using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Abstract;
using TeaShop.Core.Domain;
using TeaShop.Core.Queries.Orders.GetOrderQuery;

namespace TeaShop.Core.QueryHandlers.Orders.GetOrderQueryHandler
{
    public class GetOrderQueryHandler : IRequestHandler<GetOrderQuery, Order>
    {
        private IUnitOfWork _unitOfWork;

        public GetOrderQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Order> Handle(GetOrderQuery request, CancellationToken cancellationToken)
        {
            return _unitOfWork.OrderRepository.GetOrder(request.Id);
        }
    }
}
