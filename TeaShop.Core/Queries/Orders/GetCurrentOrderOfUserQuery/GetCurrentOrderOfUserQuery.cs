using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Domain;

namespace TeaShop.Core.Queries.Orders.GetCurrentOrderOfUserQuery
{
    public class GetCurrentOrderOfUserQuery :IRequest<Order>
    {
        public Guid UserId { get; set; }

    }
}
