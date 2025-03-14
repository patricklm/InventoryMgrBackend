namespace Domain.Contracts.Repositories;

public interface IRepositoryManager
{
    IBrandRepository Brands { get; }
    ICategoryRepository Categories { get; }
    IProductRepository Products { get; }

    Task<int> SaveChangesAsync();
}
