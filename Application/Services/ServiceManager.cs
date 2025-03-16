using Domain.Contracts.Repositories;
using Domain.Contracts.Services;

namespace Application.Services;

internal class ServiceManager(IUnitOfWork repository) : IServiceManager
{
    private readonly Lazy<IBrandService> brandService = new(
        () => new BrandService(repository));

    private readonly Lazy<ICategoryService> categoryService = new(
        () => new CategoryService(repository));

    private readonly Lazy<IProductService> productService = new(
        () => new ProductService(repository));

    public IBrandService BrandService => brandService.Value;

    public ICategoryService CategoryService => categoryService.Value;

    public IProductService ProductService => productService.Value;
}