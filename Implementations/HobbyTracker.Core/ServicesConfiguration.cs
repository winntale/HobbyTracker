using AutoMapper;
using Core.Abstractions.Queries.Users;
using HobbyTracker.Core.CoreModelsMappingProfile;
using HobbyTracker.Core.Operations.Users;
using Microsoft.Extensions.DependencyInjection;

namespace HobbyTracker.Core;

public static class ServicesConfiguration
{
    public static void ConfigureCoreServices(this IServiceCollection services)
    {
        services.AddScoped<IGetUserOperations, GetUserOperations>();
        services.AddScoped<IUsersCommandOperations, UsersCommandOperations>();
    }
    
    public static void ConfigureCoreProfiles(this IMapperConfigurationExpression mc)
    {
        mc.AddMaps(typeof(UserMappingProfile).Assembly);
    }
}