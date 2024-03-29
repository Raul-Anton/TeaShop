﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Abstract;
using TeaShop.Core.Commands.Users.CreateUserCommand;
using TeaShop.Core.Domain;

namespace TeaShop.Core.CommandHandlers.Users.CreateUserCommandHandler
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand>
    {
        private IUnitOfWork _unitOfWork;

        public CreateUserCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User 
            { 
                Id = request.Id,
                Name = request.Name,
                Email = request.Email,
                Password = request.Password,
                Address = request.Address 
            };
            _unitOfWork.UserRepository.AddUser(user);
            _unitOfWork.SaveChanges();
            return Unit.Value;
        }
    }
}
