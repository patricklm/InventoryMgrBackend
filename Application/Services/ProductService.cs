using Domain.Contracts.Repositories;
using Domain.Contracts.Services;
using Domain.Dtos.Products;

namespace Application.Services;

internal class ProductService(IUnitOfWork repository) : IProductService
{
    public async Task<ProductResponse> CreateAsync(ProductCreateRequest request)
    {
        var product = request.ToProduct();
        repository.Products.Add(product);
        await repository.CompleteAsync();

        return product.ToProductResponse();
    }

    public async Task DeleteAsync(int productId)
    {
        var productToDelete = await repository.Products.GetByIdAsync(productId)
            ?? throw new Exception($"Product with id {productId} not found");

        repository.Products.Remove(productToDelete);
    }

    public async Task<IEnumerable<ProductResponse>> GetAllAsync()
    {
        var products = await repository.Products.GetAllAsync();
        return products.Select(p => p.ToProductResponse());
    }

    public async Task<ProductResponse> GetByIdAsync(int productId)
    {
        var product = await repository.Products.GetByIdAsync(productId)
           ?? throw new Exception($"Product with id {productId} not found");
        return product.ToProductResponse();
    }

    public async Task<ProductResponse> UpdateAsync(int productId, ProductUpdateRequest request)
    {
        var product = await repository.Products.GetByIdAsync(productId)
           ?? throw new Exception($"Product with id {productId} not found");

        product.Name = request.Name;
        product.Descripton = request.Descripton;
        product.Price = request.Price;
        product.UnitsInStock = request.UnitsInStock;

        await repository.CompleteAsync();

        return product.ToProductResponse();
    }
}
