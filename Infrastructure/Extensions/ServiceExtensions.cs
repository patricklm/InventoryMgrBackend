
using Application.Services;
using Domain.Contracts.Repositories;
using Domain.Contracts.Services;
using Infrastructure.Persistence;
using Infrastructure.Repositories;
using Infrastructure.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Extensions;
public static class ServiceCollectionExtensions
{
    public static void ConfigureInfrastructure(this IServiceCollection services, IConfiguration config)
    {
        // config.GetConnectionString("SqliteConn");
        var connectionString = config.GetConnectionString("SqliteConn");

        services.AddDbContext<DataContext>(options => options.UseSqlite(connectionString));
        services.AddScoped<IRepositoryManager, RepositoryManager>();
    }
}
