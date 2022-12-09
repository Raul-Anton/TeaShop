using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Abstract;
using TeaShop.Core.Domain;
using TeaShop.Core.Queries.Images.GetImageQuery;
using TeaShop.Core.Queries.Images.GetImagesQuery;

namespace TeaShop.Core.QueryHandlers.Images.GetImagesQueryHandler
{
    public class GetImagesQueryHandler : IRequestHandler<GetImagesQuery, IEnumerable<Image>>
    {
        private IUnitOfWork _unitOfWork;

        public GetImagesQueryHandler(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Image>> Handle(GetImagesQuery request, CancellationToken cancellationToken)
        {
            return _unitOfWork.ImageRepository.GetImages();
        }
    }
}
