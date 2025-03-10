using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence;
internal class DataContext() : DbContext()
{
    internal DbSet<Category> Categories => Set<Category>();
    internal DbSet<Product> Products => Set<Product>();
}
