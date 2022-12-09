using TeaShop.Core.CommandHandlers.Products;
using TeaShop.Core.CommandHandlers.Users;
using TeaShop.Core.CommandHandlers.Users.CreateUserCommandHandler;
using TeaShop.Core.CommandHandlers.Users.DeleteUserCommandHandler;
using TeaShop.Core.CommandHandlers.Users.UpdateUserCommandHandlers;
using TeaShop.Core.Commands.Products;
using TeaShop.Core.Commands.Users;
using TeaShop.Core.Commands.Users.CreateUserCommand;
using TeaShop.Core.Commands.Users.DeleteUserCommand;
using TeaShop.Core.Commands.Users.UpdateUserCommands;
using TeaShop.Core.Domain;
using TeaShop.Core.Queries.Products;
using TeaShop.Core.Queries.Users;
using TeaShop.Core.Queries.Users.GetUsersQuery;
using TeaShop.Core.QueryHandlers.Products;
using TeaShop.Core.QueryHandlers.Users;
using TeaShop.Core.QueryHandlers.Users.GetUsersQueryHandler;
using TeaShop.Infrastructure.Data;

var createUserCommand = new CreateUserCommand
{
    Id = new Guid(),
    Name = "User1",
    Email = "user1@gmail",
    Password = "Password",
    Address = new Address()
};

var deleteUserCommand = new DeleteUserCommand
{
    Id = new Guid(),
};

var updateUserNameCommand = new UpdateUserNameCommand
{
    Id = new Guid(),
    Name = "John"
};

var appDbContext = new AppDbContext();

var unitOfWork = new UnitOfWork(appDbContext);

var createUserHandler = new CreateUserCommandHandler(unitOfWork);
//var deleteUserHandler = new DeleteUserCommandHandler(unitOfWork);
var updateUserNameHandler = new UpdateUserNameCommandHandler(unitOfWork);

createUserHandler.Handle(createUserCommand, new System.Threading.CancellationToken()).Wait();
//deleteUserHandler.Handle(deleteUserCommand, new System.Threading.CancellationToken()).Wait();
updateUserNameHandler.Handle(updateUserNameCommand, new System.Threading.CancellationToken()).Wait();






var query = new GetUsersQuery();

var queryHandler = new GetUsersQueryHandler(unitOfWork);

var userList = await queryHandler.Handle(query, new System.Threading.CancellationToken());

foreach (var user in userList)
{
    Console.WriteLine(user.Id);
    Console.WriteLine(user.Name);
    Console.WriteLine(user.Email);
    Console.WriteLine(user.Password);
    Console.WriteLine(user.Address);

}

Console.WriteLine();
