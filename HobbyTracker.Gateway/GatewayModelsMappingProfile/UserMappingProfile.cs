using AutoMapper;
using Core.Abstractions.Queries.Users.CommandModels;
using HobbyTracker.Gateway.Models;

namespace HobbyTracker.Gateway.GatewayModelsMappingProfile;

public class UserMappingProfile : Profile
{
    public UserMappingProfile()
    {
        CreateMap<UserRequestModel, UserCommandModel>();
    }
}