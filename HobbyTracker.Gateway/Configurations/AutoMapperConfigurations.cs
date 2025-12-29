using HobbyTracker.Dal;

namespace HobbyTracker.Configurations;

public static class AutoMapperConfigurations
{
    public static void ConfigureAutoMapper(this IServiceCollection services)
    {
        services.AddAutoMapper(mc =>
        {
            mc.ConfigureDalProfiles();
        });
    }
}