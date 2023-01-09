using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeaShop.Core.Commands.Orders.DeleteOrderCommand;
using TeaShop.Core.Commands.ProductOrders.CreateProductOrderCommand;
using TeaShop.Core.Commands.ProductOrders.DeleteProductOrderCommand;
using TeaShop.Core.Commands.ProductOrders.UpdateProductOrderCommand;
using TeaShop.Core.Domain;
using TeaShop.Core.DTO.ProductOrder;
using TeaShop.Core.Queries.Orders.GetOrderQuery;
using TeaShop.Core.Queries.ProductOrders.GetProductOrderQuery;
using TeaShop.Core.Queries.ProductOrders.GetProductOrdersQuery;
using TeaShop.Core.Queries.Products.GetProductQuery;

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
            var productOrder = await _mediator.Send(new GetProductOrderQuery { Id = id });
            var productOrderDTO = _mapper.Map<ProductOrderDTO_Id>(productOrder);
            return Ok(productOrderDTO);
        }

        [HttpPost]
        public async Task<IActionResult> PostProductOrder([FromBody] ProductOrderDTO productOrderDTO)
        {
            var product = await _mediator.Send(new GetProductQuery { Id = productOrderDTO.ProductId });
            var order = await _mediator.Send(new GetOrderQuery { Id = productOrderDTO.OrderId });

            var productOrder = await _mediator.Send(new CreateProductOrderCommand
            {
                Id = new Guid(),
                Product = product,
                Order = order
            }
            );

            var result = CreatedAtAction(nameof(GetProductOrder), new { Id = _mapper.Map<ProductOrderDTO, ProductOrder>(productOrderDTO).Id }, productOrder);
            return result;
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateProductOrder(Guid id, [FromBody] ProductOrderDTO productOrderDTO)
        {
            var product = await _mediator.Send(new GetProductQuery { Id = productOrderDTO.ProductId });
            var order = await _mediator.Send(new GetOrderQuery { Id = productOrderDTO.OrderId });

            var productOrder = await _mediator.Send(new UpdateProductOrderCommand
            {
                Id = id,
                ProductOrder = new ProductOrder
                {
                    Product = product,
                    Order = order
                }
            }
            );

            var result = CreatedAtAction(nameof(GetProductOrder), new { Id = _mapper.Map<ProductOrderDTO, ProductOrder>(productOrderDTO).Id }, productOrder);
            return result;
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteProductOrder(Guid id)
        {
            var productOrder = await _mediator.Send(new DeleteProductOrderCommand { Id = id });

            return Ok();
        }
    }
}
