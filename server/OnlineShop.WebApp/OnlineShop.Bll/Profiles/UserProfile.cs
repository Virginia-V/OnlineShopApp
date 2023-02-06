using AutoMapper;
using OnlineShop.Common.Dtos.Users;
using OnlineShop.Domain.Auth;

namespace OnlineShop.Bll.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<User, RegisterModelDto>();
            CreateMap<User, LoginModelDto>();
            CreateMap<User, ChangeUserDto>();
        }
    }
}
