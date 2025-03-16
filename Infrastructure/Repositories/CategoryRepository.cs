

using Domain.Contracts.Repositories;
using Domain.Entities;
using Infrastructure.Persistence;

namespace Infrastructure.Repositories;

internal class CategoryRepository(DataContext context) : Repository<Category>(context), ICategoryRepository
{
    // use Conext inherited from Repository<Category>
}
