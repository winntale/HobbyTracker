using HobbyTracker.Configurations;
using HobbyTracker.Dal;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureAutoMapper();

builder.Services.ConfigureDatabase(builder.Configuration);

builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

await app.Services.MigrateDbAsync();

app.UseHttpsRedirection();

app.Run();