using TeaShop.Core.CommandHandlers.Users;
using TeaShop.Core.Commands.User;
using TeaShop.Core.Domain;
using TeaShop.Core.Queries.Users;
using TeaShop.Core.QueryHandlers.Users;
using TeaShop.Infrastructure.Data;

var userCommand = new CreateUserCommand
{
    Id = new Guid(),
    Name = "User1"
};


var appDbContext = new AppDbContext();

var unitOfWork = new UnitOfWork(appDbContext);

var userHandler = new CreateUserCommandHandler(unitOfWork);

userHandler.Handle(userCommand, new System.Threading.CancellationToken()).Wait();


var query = new GetUsersQuery();

var queryHandler = new GetUsersQueryHandler(unitOfWork);

var userList = await queryHandler.Handle(query, new System.Threading.CancellationToken());

foreach (var user in userList)
{
    Console.WriteLine(user.Name);
    Console.WriteLine(user.Id);
}

Console.WriteLine();


