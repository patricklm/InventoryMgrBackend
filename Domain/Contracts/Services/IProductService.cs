using Domain.Dtos.Products;

namespace Domain.Contracts.Services;

public interface IProductService
{
    Task<IEnumerable<ProductResponse>> GetAllAsync();
    Task<ProductResponse> GetByIdAsync(int productId);
    Task<ProductResponse> CreateAsync(ProductCreateRequest request);
    Task<ProductResponse> UpdateAsync(int productId, ProductUpdateRequest request);
    Task DeleteAsync(int productId);
}
