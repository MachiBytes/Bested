// Bested.API\Configurations\ScalarConfiguration.cs
using Scalar.AspNetCore;

namespace Bested.API.Configurations
{
    public static class ScalarConfiguration
    {
        public static void ConfigureScalar(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.MapScalarApiReference(
                    endpointPrefix: "/", 
                    options => 
                    {
                        options.WithTitle("Restaurants API");
                    }
                );
            }
        }
    }
}
