using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Abstract;
using TeaShop.Core.Domain;
using TeaShop.Core.Queries.Products.GetProductQuery;

namespace TeaShop.Core.QueryHandlers.Products.GetProductQueryHandler
{
    public class GetProductQueryHandler : IRequestHandler<GetProductQuery, Product>
    {
        private IUnitOfWork _unitOfWork;

        public GetProductQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Product> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            return _unitOfWork.ProductRepository.GetProduct(request.Id);
        }
    }
}
