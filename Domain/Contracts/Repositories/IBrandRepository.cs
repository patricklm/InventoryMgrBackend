using Domain.Entities;

namespace Domain.Contracts.Repositories;
public interface IBrandRepository
{
    Task<IEnumerable<Brand>> GetAllAsync();
    Task<Brand?> GetByIdAsync(int brandId);
    void Insert(Brand brand);
    void Remove(Brand brand);
}
