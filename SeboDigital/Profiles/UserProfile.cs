using AutoMapper;
using SeboDigital.Data.Dtos;
using SeboDigital.Models;

namespace SeboDigital.Profiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<CreateUserDto, User>();
        CreateMap<User, ReadUserDto>()
            .ForMember(UserDto => UserDto.Books,
            opt => opt.MapFrom(user => user.Books))

            .ForMember(UserDto => UserDto.Evaluations,
            opt => opt.MapFrom(user => user.Evaluations));

    }
}
