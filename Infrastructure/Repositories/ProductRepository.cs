using Domain.Repositories;
using Infrastructure.Persistence;

namespace Infrastructure.Repositories;
internal class ProductRepository(DataContext context) : IProductRepository
{

}
