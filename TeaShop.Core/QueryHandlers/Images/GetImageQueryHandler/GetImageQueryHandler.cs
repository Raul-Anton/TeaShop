using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Abstract;
using TeaShop.Core.Domain;
using TeaShop.Core.Queries.Images.GetImageQuery;

namespace TeaShop.Core.QueryHandlers.Images.GetImageQueryHandler
{
    public class GetImageQueryHandler : IRequestHandler<GetImageQuery, Image>
    {
        private IUnitOfWork _unitOfWork;

        public GetImageQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Image> Handle(GetImageQuery request, CancellationToken cancellationToken)
        {
            return _unitOfWork.ImageRepository.GetImage(request.Id);
        }
    }
}
