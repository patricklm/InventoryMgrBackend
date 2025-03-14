using Domain.Dtos.Categories;

namespace Domain.Contracts.Services;

public interface ICategoryService
{
    Task<IEnumerable<CategoryResponse>> GetAllAsync();
    Task<CategoryResponse> GetByIdAsync(int categoryId);
    Task<CategoryResponse> CreateAsync(CategoryCreateRequest request);
    Task<CategoryResponse> UpdateAsync(int categoryId, CategoryUpdateRequest request);
    Task DeleteAsync(int categoryId);
}
