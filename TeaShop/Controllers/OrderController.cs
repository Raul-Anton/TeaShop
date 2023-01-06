using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeaShop.Core.Commands.Orders.CreateOrderCommand;
using TeaShop.Core.Domain;
using TeaShop.Core.DTO.Order;
using TeaShop.Core.DTO.User;
using TeaShop.Core.Queries.Orders.GetOrderQuery;
using TeaShop.Core.Queries.Orders.GetOrdersQuery;

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
        public async Task<IActionResult> PostOrder([FromBody] UserDTO userDTO)
        {
            return Ok();
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateOrder(Guid Id, Order o)
        {
            return Ok();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteOrder(Guid id)
        {
            return Ok();
        }
    }
}
