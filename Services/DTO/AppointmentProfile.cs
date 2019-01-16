using AutoMapper;
using Domain.Entities;

namespace Services.DTO
{
    public class AppointmentProfile : Profile
    {
        public AppointmentProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Appointment, AppointmentDto>()
                .ForMember(des => des.OrganizerFullName, opt => opt.MapFrom(src => src.Organizer.FullName));
        }
    }
}
