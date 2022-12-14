using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Abstract;
using TeaShop.Core.Commands.Users.DeleteUserCommand;

namespace TeaShop.Core.CommandHandlers.Users.DeleteUserCommandHandler
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand>
    {
        private IUnitOfWork _unitOfWork;

        public DeleteUserCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            _unitOfWork.UserRepository.DeleteUser(request.Id);
            _unitOfWork.SaveChanges();
            return Unit.Value;
        }
    }
}
