using Domain.Contracts.Repositories;
using Domain.Contracts.Services;
using Domain.Dtos.Brands;

namespace Application.Services;
internal sealed class BrandService(IRepositoryManager repository) : IBrandService
{
    public async Task<BrandResponse> CreateAsync(BrandCreateRequest request)
    {
        var brand = request.ToBrand();

        repository.Brands.Insert(brand);
        await repository.SaveChangesAsync();

        return brand.ToBrandResponse();
    }

    public async Task DeleteAsync(int brandId)
    {
        var brandToDelete = await repository.Brands.GetByIdAsync(brandId)
            ?? throw new Exception($"Brand with id {brandId} not found");

        repository.Brands.Remove(brandToDelete);
        await repository.SaveChangesAsync();
    }

    public async Task<IEnumerable<BrandResponse>> GetAllAsync()
    {
        var brands = await repository.Brands.GetAllAsync();
        return brands.Select(b => b.ToBrandResponse());
    }

    public async Task<BrandResponse> GetByIdAsync(int brandId)
    {
        var brand = await repository.Brands.GetByIdAsync(brandId)
            ?? throw new Exception($"Brand with id {brandId} not found");
            
        return brand.ToBrandResponse();
    }

    public async Task<BrandResponse> UpdateAsync(int brandId, BrandUpdateRequest request)
    {
        var brand = await repository.Brands.GetByIdAsync(brandId)
            ?? throw new Exception($"Brand with id {brandId} not found");

        brand.Name = request.Name;

        await repository.SaveChangesAsync();

        return brand.ToBrandResponse();
    }
}
