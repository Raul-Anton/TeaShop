using TeaShop.Core.CommandHandlers.Products;
using TeaShop.Core.CommandHandlers.Users;
using TeaShop.Core.CommandHandlers.Users.CreateUserCommandHandler;
using TeaShop.Core.CommandHandlers.Users.DeleteUserCommandHandler;
using TeaShop.Core.CommandHandlers.Users.UpdateUserCommandHandler;
using TeaShop.Core.Commands.Products;
using TeaShop.Core.Commands.Users;
using TeaShop.Core.Commands.Users.CreateUserCommand;
using TeaShop.Core.Commands.Users.DeleteUserCommand;
using TeaShop.Core.Commands.Users.UpdateUserCommand;
using TeaShop.Core.Domain;
using TeaShop.Core.Queries.Products;
using TeaShop.Core.Queries.Users;
using TeaShop.Core.Queries.Users.GetUserQuery;
using TeaShop.Core.Queries.Users.GetUsersQuery;
using TeaShop.Core.QueryHandlers.Products;
using TeaShop.Core.QueryHandlers.Users;
using TeaShop.Core.QueryHandlers.Users.GetUserQueryHandler;
using TeaShop.Core.QueryHandlers.Users.GetUsersQueryHandler;
using TeaShop.Infrastructure.Data;

var createUserCommand = new CreateUserCommand
{
    Id = new Guid(),
    Name = "User1",
    Email = "user1@gmail",
    Password = "Password",
    Address = new Address
    {
        Id= new Guid(),
        City = "Timisoara",
        Number = 42,
        Street = "Ganea",
    }

};

var createUserCommand2 = new CreateUserCommand
{
    Id = new Guid(),
    Name = "User2",
    Email = "user2@gmail",
    Password = "Password2",
    Address = new Address
    {
        Id = new Guid(),
        City = "Timisoara2",
        Number = 422,
        Street = "Ganea2",
    }

};

var deleteUserCommand = new DeleteUserCommand
{
    Id = new Guid("24A3348B-C745-4459-97AB-08DADDE7BFEA"),
};

var updateUser = new User
{
    Id = new Guid(),
    Name = "UpdatedUser",
    Email = "updatedUser@gmail",
    Password = "updatedPassword",
    Address = new Address
    {
        Id = new Guid(),
        City = "updatedCity",
        Number = 40,
        Street = "updatedStreet",
    }
};

var updateUserCommand = new UpdateUserCommand
{
    Id = new Guid("24A3348B-C745-4459-97AB-08DADDE7BFEA"),
    User = updateUser
};

// Initialize appDbContext and UnitOfWork
var appDbContext = new AppDbContext();

var unitOfWork = new UnitOfWork(appDbContext);



// Create Commands
//var createUserHandler = new CreateUserCommandHandler(unitOfWork);
//var createUserHandler2 = new CreateUserCommandHandler(unitOfWork);

//var deleteUserHandler = new DeleteUserCommandHandler(unitOfWork);
//var updateUserHandler = new UpdateUserCommandHandler(unitOfWork);

// Handle Commands
//createUserHandler.Handle(createUserCommand, new System.Threading.CancellationToken()).Wait();
//createUserHandler2.Handle(createUserCommand2, new System.Threading.CancellationToken()).Wait();

//deleteUserHandler.Handle(deleteUserCommand, new System.Threading.CancellationToken()).Wait();
//updateUserHandler.Handle(updateUserCommand, new System.Threading.CancellationToken()).Wait();



// Queries
var getUsersQuery = new GetUsersQuery();

Guid id = new Guid("24A3348B-C745-4459-97AB-08DADDE7BFEA");
var getUserQuery = new GetUserQuery
{
    Id = id
};

// QueruesHandlers
var getUsersQueryHandler = new GetUsersQueryHandler(unitOfWork);
//var getUserQueryHandler = new GetUserQueryHandler(unitOfWork);

// Use Queries
var getUsersQueryResult = await getUsersQueryHandler.Handle(getUsersQuery, new System.Threading.CancellationToken());
//var getUserQueryResult = await getUserQueryHandler.Handle(getUserQuery, new System.Threading.CancellationToken());


foreach (var user in getUsersQueryResult)
{
    Console.WriteLine(user.Id);
    Console.WriteLine(user.Name);
    Console.WriteLine(user.Email);
    Console.WriteLine(user.Password);
    Console.WriteLine(user.Address);
    Console.WriteLine();
}


/*
Console.WriteLine(getUserQueryResult.Id);
Console.WriteLine(getUserQueryResult.Name);
Console.WriteLine(getUserQueryResult.Email);
Console.WriteLine(getUserQueryResult.Password);
Console.WriteLine(getUserQueryResult.Address);
*/