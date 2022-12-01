using TeaShop.Core.CommandHandlers.Products;
using TeaShop.Core.CommandHandlers.Users;
using TeaShop.Core.CommandHandlers.Users.UpdateUserCommandHandlers;
using TeaShop.Core.Commands.Products;
using TeaShop.Core.Commands.Users;
using TeaShop.Core.Commands.Users.UpdateUserCommands;
using TeaShop.Core.Domain;
using TeaShop.Core.Queries.Products;
using TeaShop.Core.Queries.Users;
using TeaShop.Core.QueryHandlers.Products;
using TeaShop.Core.QueryHandlers.Users;
using TeaShop.Infrastructure.Data;

var createUserCommand = new CreateUserCommand
{
    Id = new Guid(),
    Name = "User1"
};

var createUserCommand2 = new CreateUserCommand
{
    Id = new Guid(),
    Name = "User2"
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
var deleteUserHandler = new DeleteUserCommandHandler(unitOfWork);
var updateUserNameHandler = new UpdateUserNameCommandHandler(unitOfWork);

createUserHandler.Handle(createUserCommand, new System.Threading.CancellationToken()).Wait();
createUserHandler.Handle(createUserCommand2, new System.Threading.CancellationToken()).Wait();
//deleteUserHandler.Handle(deleteUserCommand, new System.Threading.CancellationToken()).Wait();
//updateUserNameHandler.Handle(updateUserNameCommand, new System.Threading.CancellationToken()).Wait();






var query = new GetUsersQuery();

var queryHandler = new GetUsersQueryHandler(unitOfWork);

var userList = await queryHandler.Handle(query, new System.Threading.CancellationToken());

foreach (var user in userList)
{
    Console.WriteLine(user.Name);
    Console.WriteLine(user.Id);
}

Console.WriteLine();






// Product test

var productCommand = new CreateProductCommand
{
    Id = new Guid(),
    Name = "Product1"
};

var productHandler = new CreateProductCommandHandler(unitOfWork);

productHandler.Handle(productCommand, new System.Threading.CancellationToken()).Wait();

var getProductsQuery = new GetProductsQuery();

var getProductsQuertHandler = new GetProductsQueryHandler(unitOfWork);

var productsList = await getProductsQuertHandler.Handle(getProductsQuery, new System.Threading.CancellationToken());

foreach (var product in productsList)
{
    Console.WriteLine(product.Name);
    Console.WriteLine(product.Id);
}
