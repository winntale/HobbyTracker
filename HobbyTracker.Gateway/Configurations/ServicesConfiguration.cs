using AutoMapper;
using HobbyTracker.Gateway.GatewayModelsMappingProfile;

namespace HobbyTracker.Gateway.Configurations;

public static class ServicesConfiguration
{
    public static void ConfigureGatewayProfiles(this IMapperConfigurationExpression mc)
    {
        mc.AddMaps(typeof(UserMappingProfile).Assembly);
    }
}