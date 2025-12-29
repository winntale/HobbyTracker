using AutoMapper;
using Dal.Abstractions.Models;
using HobbyTracker.Dal.Entities;

namespace HobbyTracker.Dal.DalModelsMappingProfile;

public class UserMappingProfile : Profile
{
    public UserMappingProfile()
    {
        CreateMap<AddUserRepositoryModel, User>();
        CreateMap<User, UserRepositoryModel>();
    }
}