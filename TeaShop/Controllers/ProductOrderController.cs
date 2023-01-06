using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeaShop.Core.Commands.Users.CreateUserCommand;
using TeaShop.Core.Commands.Users.DeleteUserCommand;
using TeaShop.Core.Commands.Users.UpdateUserCommand;
using TeaShop.Core.Domain;
using TeaShop.Core.DTO.User;
using TeaShop.Core.Queries.ProductOrders.GetProductOrdersQuery;
using TeaShop.Core.Queries.Users.GetUserQuery;

namespace TeaShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductOrderController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public ProductOrderController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetProductOrders()
        {
            var productOrders = await _mediator.Send(new GetProductOrdersQuery());

            return Ok(productOrders);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetProductOrder(Guid id)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> PostProductOrder()
        {
            return Ok();
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateProductOrder(Guid Id, ProductOrder p)
        {
            return Ok();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteProductOrder(Guid id)
        {
            return Ok();
        }
    }
}
