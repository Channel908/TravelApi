using TravelApi.Persistence;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services
    .AddPersistence(builder.Configuration);


// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapGet("/", () =>
{
    return Results.Ok();
});

app.Run();
