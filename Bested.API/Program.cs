// Bested.API\Program.cs
using Bested.API.Configurations;
using Bested.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.ExtendPresentation();

var app = builder.Build();

app.MapControllers();
app.ConfigureScalar();
app.Run();
