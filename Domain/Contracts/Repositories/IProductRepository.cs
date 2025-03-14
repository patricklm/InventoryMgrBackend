using Domain.Entities;

namespace Domain.Contracts.Repositories;
public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAllAsync();
    Task<Product?> GetByIdAsync(int productId);
    void Insert(Product product);
    void Remove(Product product);
}
