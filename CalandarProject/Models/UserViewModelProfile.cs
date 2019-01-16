using AutoMapper;
using Services.DTO;

namespace CalandarProject.Models
{
    public class UserViewModelProfile : Profile
    {
        public UserViewModelProfile()
        {
            CreateMap<UserDto, UserViewModel>().ReverseMap();
        }
    }
}