using AutoMapper;
using Core.Abstractions.Queries.Users.CommandModels;
using Core.Abstractions.Queries.Users.QueryModels;
using Dal.Abstractions.Models;

namespace HobbyTracker.Core.CoreModelsMappingProfile;

public class UserMappingProfile : Profile
{
    public UserMappingProfile()
    {
        CreateMap<UserRepositoryModel, UserResultModel>();
        CreateMap<UserCommandModel, AddUserRepositoryModel>();
    }
}