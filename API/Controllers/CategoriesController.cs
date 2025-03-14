using Domain.Contracts.Services;
using Domain.Dtos.Categories;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController(IServiceManager service) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryResponse>>> GetCategories()
        {
            return Ok(await service.CategoryService.GetAllAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<CategoryResponse>> GetCategory(int id)
        {
            return Ok(await service.CategoryService.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<ActionResult<CategoryResponse>> CreateCategory([FromBody] CategoryCreateRequest request)
        {
            var category = await service.CategoryService.CreateAsync(request);
            return CreatedAtAction(nameof(GetCategory), new { category.Id }, category);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<CategoryResponse>> UpdateCategory(int id, [FromBody] CategoryUpdateRequest request)
        {
            return Ok(await service.CategoryService.UpdateAsync(id, request));
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteCategory(int id)
        {
            await service.CategoryService.DeleteAsync(id);
            return NoContent();
        }
    }
}
