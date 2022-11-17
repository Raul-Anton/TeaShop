using MediatR;
using TeaShop.Core.Domain;

namespace TeaShop.Core.Queries.Users
{
    public class GetUsersQuery : IRequest<IEnumerable<User>>
    {
        
    }
}
