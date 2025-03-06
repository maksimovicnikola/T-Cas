using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_Cas.Business.Models;
using T_Cas.Data.Entities;

namespace T_Cas.Business.MappingProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<CreateUserDto, User>()
                .ForMember(dest => dest.PasswordHash, opt => opt.Ignore());

            CreateMap<User, CreateUserDto>();

            CreateMap<UpdateUserDto, User>()
                .ForMember(dest => dest.PasswordHash, opt => opt.Ignore());

            CreateMap<User, UpdateUserDto>();

            CreateMap<User, UserDto>()
                .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.Role))
                .ForMember(dest => dest.MicUser, opt => opt.MapFrom(src => src.MicUser));

            CreateMap<Role, RoleDto>().ReverseMap();
            CreateMap<MicUser, MicUserDto>().ReverseMap();
        }
    }
}
