using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Abstract;
using TeaShop.Core.Domain;
using TeaShop.Core.Queries.ProductOrders.GetProductOrdersQuery;

namespace TeaShop.Core.QueryHandlers.ProductOrders.GetProductOrdersQueryHandler
{
    public class GetProductOrdersQueryHandler : IRequestHandler<GetProductOrdersQuery, IEnumerable<ProductOrder>>
    {
        private IUnitOfWork _unitOfWork;

        public GetProductOrdersQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<ProductOrder>> Handle(GetProductOrdersQuery request, CancellationToken cancellationToken)
        {
            return _unitOfWork.ProductOrderRepository.GetProductOrders();
        }
    }
}
