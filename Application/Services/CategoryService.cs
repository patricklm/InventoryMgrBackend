using Domain.Contracts.Repositories;
using Domain.Contracts.Services;
using Domain.Dtos.Categories;

namespace Application.Services;

internal sealed class CategoryService(IRepositoryManager repository) : ICategoryService
{
    public async Task<CategoryResponse> CreateAsync(CategoryCreateRequest request)
    {
        var category = request.ToCategory();
        repository.Categories.Insert(category);
        await repository.SaveChangesAsync();

        return category.ToCategoryResponse();
    }

    public async Task DeleteAsync(int categoryId)
    {
        var categoryToRemove = await repository.Categories.GetByIdAsync(categoryId)
            ?? throw new Exception($"Category with id {categoryId} not found");

        repository.Categories.Remove(categoryToRemove);
        await repository.SaveChangesAsync();

    }

    public async Task<IEnumerable<CategoryResponse>> GetAllAsync()
    {
        var categories = await repository.Categories.GetAllAsync();
        return categories.Select(c => c.ToCategoryResponse());
    }

    public async Task<CategoryResponse> GetByIdAsync(int categoryId)
    {
        var category = await repository.Categories.GetByIdAsync(categoryId)
            ?? throw new Exception($"Category with id {categoryId} not found");
        return category.ToCategoryResponse();
    }

    public async Task<CategoryResponse> UpdateAsync(int categoryId, CategoryUpdateRequest request)
    {
        var category = await repository.Categories.GetByIdAsync(categoryId)
            ?? throw new Exception($"Category with id {categoryId} not found");

        category.Name = request.Name;
        await repository.SaveChangesAsync();
        return category.ToCategoryResponse();
    }
}
