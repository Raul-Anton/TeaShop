using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Abstract;
using TeaShop.Core.Domain;

namespace TeaShop.Core.Queries.Orders.GetCurrentOrdersOfUserQuery
{
    public class GetCurrentOrdersOfUserQuery : IRequest<IEnumerable<Order>>
    {
        public Guid UserId { get; set; }
    }
}
