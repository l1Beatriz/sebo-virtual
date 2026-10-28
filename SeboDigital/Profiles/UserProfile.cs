using AutoMapper;
using SeboDigital.Data.Dtos;
using SeboDigital.Models;

namespace SeboDigital.Profiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<CreateUserDto, User>();
        CreateMap<User, ReadUserDto>();
    }
}
