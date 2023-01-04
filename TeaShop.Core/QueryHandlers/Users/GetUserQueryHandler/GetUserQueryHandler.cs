using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Abstract;
using TeaShop.Core.Domain;
using TeaShop.Core.Queries.Users.GetUserQuery;

namespace TeaShop.Core.QueryHandlers.Users.GetUserQueryHandler
{
    public class GetUserQueryHandler : IRequestHandler<UpdateUserQuery, User>
    {
        private IUnitOfWork _unitOfWork;

        public GetUserQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<User> Handle(UpdateUserQuery request, CancellationToken cancellationToken)
        {
            return _unitOfWork.UserRepository.GetUser(request.Id);
        }
    }
}
