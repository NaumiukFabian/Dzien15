using Microsoft.AspNetCore.Mvc;
using P04Sklep.API.Services.ProductService;
using P05Sklep.Shared;

namespace P04Sklep.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<Product[]>>> GetProducts()
        {
            var result = await _productService.GetProductAsync();
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<Product>>> UpdateProduct(Product product)
        {
            var result = await _productService.UpdateProduct(product);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<Product>>> CreateProduct([FromBody]Product product)
        {
            var result = await _productService.CreateProductAsync(product);
            return Ok(result);
        }

        //https://localhost:7131/api/product/4
        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<bool>>> DeleteProduct([FromRoute]int id)
        {
            var result = await _productService.DeleteProductAsync(id);
            return Ok(result);
        }
    }
}
