using Domain.Contracts.Repositories;
using Infrastructure.Persistence;

namespace Infrastructure.Repositories;

internal class UnitOfWork(DataContext context) : IUnitOfWork, IDisposable
{
    private readonly DataContext _context = context;

    // Properties
    public IBrandRepository Brands { get; private set; } = new BrandRepository(context);
    public ICategoryRepository Categories { get; private set; } = new CategoryRepository(context);
    public IProductRepository Products { get; private set; } = new ProductRepository(context);

    // Methods
    public async Task<bool> CompleteAsync()
    {
        return await _context.SaveChangesAsync() > 0;
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
