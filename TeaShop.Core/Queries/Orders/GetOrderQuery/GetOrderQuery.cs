using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Domain;

namespace TeaShop.Core.Queries.Orders.GetOrderQuery
{
    public class GetOrderQuery : IRequest<Order>
    {
        public Guid Id { get; set; }
    }
}
