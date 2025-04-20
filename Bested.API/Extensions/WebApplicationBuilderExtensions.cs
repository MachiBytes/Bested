// Bested.API\Extensions\WebApplicationBuilderExtensions.cs
using Serilog;

namespace Bested.API.Extensions
{
    public static class WebApplicationBuilderExtensions
    {
        public static void ExtendPresentation(this WebApplicationBuilder builder)
        {
            builder.Host.UseSerilog((context, configuration) => 
                configuration.ReadFrom.Configuration(context.Configuration)
            );
        
            builder.Services.AddControllers();
            builder.Services.AddOpenApi();
        }
    }
}
