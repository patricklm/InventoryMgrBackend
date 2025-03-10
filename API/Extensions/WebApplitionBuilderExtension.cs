using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace API.Extensions;
public static class WebApplitionBuilderExtension
{
    public static void AddPresentation(this WebApplicationBuilder builder)
    {
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
    }
}
