using Domain.Contracts.Repositories;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;
internal class ProductRepository(DataContext context) : IProductRepository
{
    public async Task<IEnumerable<Product>> GetAllAsync()
    {
        return await context.Products.ToListAsync();
    }

    public async Task<Product?> GetByIdAsync(int productId)
    {
        return await context.Products.FirstOrDefaultAsync(p => p.Id == productId);
    }

    public void Insert(Product product)
    {
        context.Products.Add(product);
    }

    public void Remove(Product product)
    {
        context.Products.Remove(product);
    }
}
