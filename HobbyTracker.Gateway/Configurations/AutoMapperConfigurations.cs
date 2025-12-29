using HobbyTracker.Gateway.Configurations;
using HobbyTracker.Core;
using HobbyTracker.Dal;

namespace HobbyTracker.Gateway.Configurations;

public static class AutoMapperConfigurations
{
    public static void ConfigureAutoMapper(this IServiceCollection services)
    {
        services.AddAutoMapper(mc =>
        {
            mc.ConfigureCoreProfiles();
            mc.ConfigureDalProfiles();
            mc.ConfigureGatewayProfiles();
        });
    }
}