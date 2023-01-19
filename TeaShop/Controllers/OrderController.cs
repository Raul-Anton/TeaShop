using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;
using TeaShop.Core.Commands.Orders.CreateOrderCommand;
using TeaShop.Core.Commands.Orders.DeleteOrderCommand;
using TeaShop.Core.Commands.Orders.UpdateOrderCommand;
using TeaShop.Core.Domain;
using TeaShop.Core.DTO.Order;
using TeaShop.Core.DTO.User;
using TeaShop.Core.Queries.Orders.GetOrderQuery;
using TeaShop.Core.Queries.Orders.GetOrdersQuery;
using TeaShop.Core.Queries.ProductOrders.GetProductOrderQuery;
using TeaShop.Core.Queries.Users.GetUserQuery;

namespace TeaShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public OrderController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetOrders()
        {
            var orders = await _mediator.Send(new GetOrdersQuery());

            return Ok(orders);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetOrder(Guid id)
        {
            var order = await _mediator.Send(new GetOrderQuery { Id = id });
            var orderDTO = _mapper.Map<OrderDTO_Id>(order);

            return Ok(orderDTO);
        }

        [HttpPost]
        public async Task<IActionResult> PostOrder([FromBody] OrderDTO orderDTO)
        {
            var user = await _mediator.Send(new GetUserQuery { Id = orderDTO.UserId });

            var order = await _mediator.Send(new CreateOrderCommand
            {
                Id = new Guid(),
                User = user,
            }
            );

            var result = CreatedAtAction(nameof(GetOrder), new { Id = _mapper.Map<OrderDTO, Order>(orderDTO).Id }, order);
            return result;
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateOrder(Guid id, [FromBody] OrderDTO_OrderStatus orderDTO_OrderStatus)
        {
            var user = await _mediator.Send(new GetUserQuery { Id = orderDTO_OrderStatus.UserId });

            var order = _mediator.Send(new UpdateOrderCommand
            {
                Id = id,
                Order = new Order
                {
                    User = user,
                    orderStatus = orderDTO_OrderStatus.orderStatus,
                }
                
            }
);

            var result = CreatedAtAction(nameof(GetOrder), new { Id = _mapper.Map<OrderDTO_OrderStatus, Order>(orderDTO_OrderStatus).Id }, order);
            return result;
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteOrder(Guid id)
        {
            var order = await _mediator.Send(new DeleteOrderCommand { Id = id });

            return Ok();
        }
    }
}
