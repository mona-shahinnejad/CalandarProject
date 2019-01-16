using AutoMapper;
using Domain.Entities;

namespace Services.DTO
{
    public class UserDtoProfile : Profile
    {
        public UserDtoProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
