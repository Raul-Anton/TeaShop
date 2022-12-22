using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeaShop.Core.Queries.ProductOrders.GetProductOrdersQuery;

namespace TeaShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductOrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductOrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetProductOrders()
        {
            var users = await _mediator.Send(new GetProductOrdersQuery());

            return Ok(users);
        }
    }
}
