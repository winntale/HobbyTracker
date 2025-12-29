using HobbyTracker.Gateway.Configurations;
using HobbyTracker.Core;
using HobbyTracker.Dal;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureAutoMapper();

builder.Services.ConfigureDatabase(builder.Configuration);

builder.Services.ConfigureCoreServices();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

await app.Services.MigrateDbAsync();

app.MapGet("/ping", () => "OK");

app.MapControllers();

app.Run();