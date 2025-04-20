// Bested.API\Extensions\WebApplicationBuilderExtensions.cs
namespace Bested.API.Extensions;

public static class WebApplicationBuilderExtensions
{
    public static void ExtendPresentation(this WebApplicationBuilder builder)
    {
        builder.Services.AddControllers();
        builder.Services.AddOpenApi();
    }
}
