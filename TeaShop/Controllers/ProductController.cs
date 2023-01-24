using AutoMapper;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
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
        private static string _currentImagePath { get; set; }

        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        //private readonly IImageService _imageService;

        public ProductController(IMediator mediator, IMapper mapper/*, IImageService imageService*/)
        {
            _mediator = mediator;
            _mapper = mapper;
            //_imageService = imageService;
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
        [Route("image")]
        public async Task<IActionResult> UploadImage(IFormFile file)
        {
            string fileName = file.FileName;
            string imagePath = AppDomain.CurrentDomain.BaseDirectory + new Guid() +fileName ;

            //Console.WriteLine(imagePath);

            using (FileStream stream = System.IO.File.Create(imagePath))
            {
                await file.CopyToAsync(stream);
            }

            _currentImagePath= imagePath;
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> PostProduct([FromBody] ProductDTO productDTO)
        {
            BlobServiceClient blobServiceClient = new BlobServiceClient("DefaultEndpointsProtocol=https;AccountName=storageaccountinternship;AccountKey=RZ+vz/KG1fOfe+zEi8n9TtNU9UY9ZpkZbjEgbNA/2xD1TN9+W3/lnFoZipJUn8atienNkjMDbKI1haB1vrLeCQ==;EndpointSuffix=core.windows.net");
            BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient("images");

            //Console.WriteLine(_currentImagePath + "1234");

            using (MemoryStream stream = new MemoryStream(System.IO.File.ReadAllBytes(_currentImagePath))) {
                containerClient.UploadBlob(Path.GetFileName(_currentImagePath), stream);
            }

            BlobClient blobClient = containerClient.GetBlobClient(_currentImagePath.Substring(_currentImagePath.LastIndexOf(@"\") + 1));


            string azurePath = blobClient.Uri.AbsoluteUri;
                //await _imageService.UploadFormFileAsync(productDTO.ImageFile);
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
            string azurePath = "azure";
                //await _imageService.UploadFormFileAsync(productDTO.ImageFile);
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
