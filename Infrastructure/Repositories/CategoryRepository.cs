

using Domain.Contracts.Repositories;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;
internal class CategoryRepository(DataContext context) : ICategoryRepository
{
    public async Task<IEnumerable<Category>> GetAllAsync()
    {
        return await context.Categories.ToListAsync();
    }

    public async Task<Category?> GetByIdAsync(int categoryId)
    {
        return await context.Categories.FirstOrDefaultAsync(c => c.Id == categoryId);
    }

    public void Insert(Category category)
    {
        context.Categories.Add(category);
    }

    public void Remove(Category category)
    {
        context.Categories.Remove(category);
    }
}
