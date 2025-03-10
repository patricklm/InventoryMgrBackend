using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Extensions;
public static class ServiceCollectionExtensions
{
    public static void  AddApplicatoin(this IServiceCollection services) {

        var applicationAssembly = typeof(ServiceCollectionExtensions).Assembly;
        
        services.AddValidatorsFromAssembly(applicationAssembly)
                   .AddFluentValidationAutoValidation();
        services.AddHttpContextAccessor();
    }
}
