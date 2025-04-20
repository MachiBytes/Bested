// Bested.API\Program.cs
using Bested.API.Configurations;
using Bested.API.Extensions;
using Bested.Infrastructure.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.ExtendPresentation();
builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();

app.MapControllers();
app.ConfigureScalar();
app.Run();
