using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence;
internal class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    internal DbSet<Category> Categories { get; set; }
    internal DbSet<Brand> Brands { get; set; }
    internal DbSet<Product> Products { get; set; }
}
