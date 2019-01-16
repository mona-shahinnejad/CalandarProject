using AutoMapper;
using Services.DTO;

namespace CalandarProject.Models
{
    public class AppointmentViewModelProfile : Profile
    {
        public AppointmentViewModelProfile()
        {
            CreateMap<UserDto, UserViewModel>().ReverseMap();
            CreateMap<AppointmentDto, AppointmentViewModel>().ReverseMap();
        }
    }
}