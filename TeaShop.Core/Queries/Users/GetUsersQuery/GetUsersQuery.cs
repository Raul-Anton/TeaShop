using MediatR;
using TeaShop.Core.Domain;

namespace TeaShop.Core.Queries.Users.GetUsersQuery
{
    public class GetUsersQuery : IRequest<IEnumerable<User>>
    {

    }
}
