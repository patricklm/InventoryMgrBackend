using Domain.Contracts.Repositories;
using Infrastructure.Persistence;

namespace Infrastructure.Repositories;

internal class RepositoryManager(DataContext context) : IRepositoryManager
{
    // Fields
    private Lazy<IBrandRepository> brandRepository = new(
        () => new BrandRepository(context));

    private Lazy<ICategoryRepository> categoryRepository = new(
        () => new CategoryRepository(context));

    private Lazy<IProductRepository> productRepository = new(() => new ProductRepository(context));

    // Properties
    public IBrandRepository Brands => brandRepository.Value;

    public ICategoryRepository Categories => categoryRepository.Value;

    public IProductRepository Products => productRepository.Value;

    // Methods
    public async Task<int> SaveChangesAsync()
    {
        return await context.SaveChangesAsync();
    }
}
