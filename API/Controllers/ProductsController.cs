using Domain.Contracts.Services;
using Domain.Dtos.Products;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController(IServiceManager service) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductResponse>>> GetProducts()
        {
            return Ok(await service.ProductService.GetAllAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ProductResponse>> GetProduct(int id)
        {
            return Ok(await service.ProductService.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<ActionResult<ProductResponse>> CreateProduct([FromBody] ProductCreateRequest request)
        {
            var product = await service.ProductService.CreateAsync(request);
            return CreatedAtAction(nameof(GetProduct), new { product.Id }, product);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<ProductResponse>> UpdateProduct(int id, [FromBody] ProductUpdateRequest request)
        {
            return Ok(await service.ProductService.UpdateAsync(id, request));
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteProduct(int id)
        {
            await service.ProductService.DeleteAsync(id);
            return NoContent();
        }
    }
}
