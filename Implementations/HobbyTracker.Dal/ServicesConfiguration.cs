using AutoMapper;
using Dal.Abstractions.Repositories;
using HobbyTracker.Dal.Context;
using HobbyTracker.Dal.DalModelsMappingProfile;
using HobbyTracker.Dal.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HobbyTracker.Dal;

public static class ServicesConfiguration
{
    public static void ConfigureDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ModelDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("HobbyTrackerDatabase")));

        services.AddScoped<IUserQueryRepository, UserQueryRepository>();
        services.AddScoped<IUserCommandRepository, UserCommandRepository>();
    }

    public static void ConfigureDalProfiles(this IMapperConfigurationExpression mc)
    {
        mc.AddMaps(typeof(UserMappingProfile).Assembly);
    }
    
    public static async Task MigrateDbAsync(this IServiceProvider serviceProvider)
    {
        using var scope = serviceProvider.CreateScope();
        var model = scope.ServiceProvider.GetService<ModelDbContext>();
        
        if (!(await model!.Database.CanConnectAsync()))
        {
            throw new Exception("No connect to database");
        }

        await model.Database.MigrateAsync();
    }
}