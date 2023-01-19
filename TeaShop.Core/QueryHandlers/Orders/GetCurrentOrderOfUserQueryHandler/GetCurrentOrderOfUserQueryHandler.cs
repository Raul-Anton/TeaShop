using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Abstract;
using TeaShop.Core.Domain;
using TeaShop.Core.DTO.Order;
using TeaShop.Core.Enum;
using TeaShop.Core.Queries.Orders.GetCurrentOrderOfUserQuery;

namespace TeaShop.Core.QueryHandlers.Orders.GetCurrentOrderOfUserQueryHandler
{
    public class GetCurrentOrderOfUserQueryHandler : IRequestHandler<GetCurrentOrderOfUserQuery, Order>
    {
        private IUnitOfWork _unitOfWork;

        public GetCurrentOrderOfUserQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Order> Handle(GetCurrentOrderOfUserQuery request, CancellationToken cancellationToken)
        {
            return _unitOfWork.OrderRepository.GetCurrentOrderOfUser(request.UserId);
        }
    }
}
