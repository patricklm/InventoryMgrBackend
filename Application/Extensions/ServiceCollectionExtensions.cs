using Application.Services;
using Domain.Contracts.Services;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Extensions;
public static class ServiceCollectionExtensions
{
    public static void ConfigureApplicatoin(this IServiceCollection services)
    {
        var applicationAssembly = typeof(ServiceCollectionExtensions).Assembly;

        services.AddScoped<IServiceManager, ServiceManager>();
        services.AddHttpContextAccessor();
        services.AddValidatorsFromAssembly(applicationAssembly)
                   .AddFluentValidationAutoValidation();
    }
}
