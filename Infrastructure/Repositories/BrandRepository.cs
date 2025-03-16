using Domain.Contracts.Repositories;
using Domain.Entities;
using Infrastructure.Persistence;

namespace Infrastructure.Repositories;

internal class BrandRepository(DataContext context) : Repository<Brand>(context), IBrandRepository
{
    // use Conext inherited from Repository<Brand>
    
}