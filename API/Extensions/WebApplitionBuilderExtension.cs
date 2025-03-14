using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace API.Extensions;
public static class WebApplitionBuilderExtension
{
    public static void ConfigurePresentation(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
    }
}
