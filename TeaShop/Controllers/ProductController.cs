using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeaShop.Core.Abstract.Services;
using TeaShop.Core.Commands.Products.CreateProductCommand;
using TeaShop.Core.Commands.Products.DeleteProductCommand;
using TeaShop.Core.Commands.Products.UpdateProductCommand;
using TeaShop.Core.Domain;
using TeaShop.Core.DTO.Product;
using TeaShop.Core.Queries.Products.GetProductQuery;
using TeaShop.Core.Queries.Products.GetProductsQuery;

namespace TeaShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        private readonly IImageService _imageService;

        public ProductController(IMediator mediator, IMapper mapper, IImageService imageService)
        {
            _mediator = mediator;
            _mapper = mapper;
            _imageService = imageService;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _mediator.Send(new GetProductsQuery());
            var productsDTO = _mapper.Map<List<ProductDTO_Id>>(products);

            return Ok(productsDTO);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetProduct(Guid id)
        {
            var product = await _mediator.Send(new GetProductQuery { Id = id });
            var productDTO = _mapper.Map<ProductDTO_Id>(product);

            if (productDTO == null) return NotFound();

            return Ok(productDTO);
        }

        [HttpPost]
        public async Task<IActionResult> PostProduct([FromBody] ProductDTO productDTO)
        {
            string azurePath = await _imageService.UploadFormFileAsync(productDTO.ImageFile);
            var product = await _mediator.Send(new CreateProductCommand
            {
                Id = new Guid(),
                Name = productDTO.Name,
                Description = productDTO.Description,
                Price = productDTO.Price,
                Quantity = productDTO.Quantity,
                Image = new Image
                {
                    AzurePath = azurePath
                }
                //moch form file
            });

            var result = CreatedAtAction(nameof(GetProduct), new { id = _mapper.Map<ProductDTO, Product>(productDTO).Id }, product);
            return result;
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> PutProduct(Guid id, [FromBody] ProductDTO productDTO)
        {
            string azurePath = await _imageService.UploadFormFileAsync(productDTO.ImageFile);
            var product = await _mediator.Send(new UpdateProductCommand
            {
                Id = id,
                Product = new Product
                {
                    Name = productDTO.Name,
                    Description = productDTO.Description,
                    Price = productDTO.Price,
                    Quantity = productDTO.Quantity,
                    Image = new Image
                    {
                        AzurePath = azurePath
                    }
                }
            });

            var result = CreatedAtAction(nameof(GetProduct), new { id = _mapper.Map<ProductDTO, Product>(productDTO).Id }, product);
            return result;
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteProduct(Guid id)
        {
            var product = await _mediator.Send(new DeleteProductCommand { Id = id });

            return Ok();
        }
    }
}
