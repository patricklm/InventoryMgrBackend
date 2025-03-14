using Domain.Entities;

namespace Domain.Contracts.Repositories;
public interface ICategoryRepository
{
    Task<IEnumerable<Category>> GetAllAsync();
    Task<Category?> GetByIdAsync(int categoryId);
    void Insert(Category category);
    void Remove(Category category);
}
