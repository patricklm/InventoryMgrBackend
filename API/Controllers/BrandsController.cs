using Domain.Contracts.Services;
using Domain.Dtos.Brands;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BrandsController(IServiceManager service) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<BrandResponse>>> GetBrands()
    {
        return Ok(await service.BrandService.GetAllAsync());
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<BrandResponse>> GetBrand([FromRoute] int id)
    {
        return Ok(await service.BrandService.GetByIdAsync(id));
    }

    [HttpPost]
    public async Task<ActionResult<BrandResponse>> CreateBrand([FromBody] BrandCreateRequest request)
    {
        var brand = await service.BrandService.CreateAsync(request);
        return CreatedAtAction(nameof(GetBrand), new { brand.Id }, brand);
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult<BrandResponse>> UpdateBrand(int id, [FromBody] BrandUpdateRequest request)
    {
        return Ok(await service.BrandService.UpdateAsync(id, request));
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult> DeleteBrand(int id)
    {
        await service.BrandService.DeleteAsync(id);
        return NoContent();
    }

}
