using Domain.Dtos.Brands;

namespace Domain.Contracts.Services;

public interface IBrandService
{
    Task<IEnumerable<BrandResponse>> GetAllAsync();
    Task<BrandResponse> GetByIdAsync(int brandId);
    Task<BrandResponse> CreateAsync(BrandCreateRequest request);
    Task<BrandResponse> UpdateAsync(int brandId, BrandUpdateRequest request);
    Task DeleteAsync(int brandId);
}
