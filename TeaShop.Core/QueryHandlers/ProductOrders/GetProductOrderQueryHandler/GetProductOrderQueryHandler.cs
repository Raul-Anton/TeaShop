using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Abstract;
using TeaShop.Core.Domain;
using TeaShop.Core.Queries.ProductOrders.GetProductOrderQuery;

namespace TeaShop.Core.QueryHandlers.ProductOrders.GetProductOrderQueryHandler
{
    public class GetProductOrderQueryHandler : IRequestHandler<GetProductOrderQuery, ProductOrder>
    {
        private IUnitOfWork _unitOfWork;

        public GetProductOrderQueryHandler(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ProductOrder> Handle(GetProductOrderQuery request, CancellationToken cancellationToken)
        {
            return _unitOfWork.ProductOrderRepository.GetProductOrder(request.Id);
        }
    }
}
