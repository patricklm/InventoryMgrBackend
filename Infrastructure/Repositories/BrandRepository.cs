using Domain.Contracts.Repositories;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;
internal class BrandRepository(DataContext context) : IBrandRepository
{
    public async Task<IEnumerable<Brand>> GetAllAsync()
    {
        return await context.Brands.ToListAsync();
    }

    public async Task<Brand?> GetByIdAsync(int brandId)
    {
        return await context.Brands.FirstOrDefaultAsync(b => b.Id == brandId);
    }

    public void Insert(Brand brand)
    {
        context.Brands.Add(brand);
    }

    public void Remove(Brand brand)
    {
        context.Brands.Remove(brand);
    }
}