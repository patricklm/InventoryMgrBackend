namespace Domain.Contracts.Services;

public interface IServiceManager
{
    IBrandService BrandService { get; }
    ICategoryService CategoryService { get; }
    IProductService ProductService { get; }
}
