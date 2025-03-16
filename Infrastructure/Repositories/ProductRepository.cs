using Domain.Contracts.Repositories;
using Domain.Entities;
using Infrastructure.Persistence;

namespace Infrastructure.Repositories;
internal class ProductRepository(DataContext context) : Repository<Product>(context), IProductRepository
{
    // use Conext inherited from Repository<Product>
}
