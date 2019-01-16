using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using AutoMapper;
using Common.Extentions;
using Domain;
using Services.DTO;
using Services.IService;

namespace Services.Service
{
    internal class AppointmentService : IAppointmentService
    {
        private readonly CalendarDatabaseContext _context;
        private readonly IMapper _mapper;

        public AppointmentService(CalendarDatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<AppointmentDto> GetAppointmetsByDate(DateTime start, DateTime end)
        {
            return _context.Appointments
                .Include(a => a.Organizer)
                .Include(a => a.Attendees)
                .Where(a => a.AppointmentDateTime >= start && a.AppointmentDateTime <= end)
                .AsEnumerable()
                .Select(a => _mapper.Map<AppointmentDto>(a));
        }

        public IEnumerable<AppointmentDto> GetAppointmetsByMonth(int month)
        {
            var date = new DateTime(DateTime.Now.Year, month, 1);

            return GetAppointmetsByDate(date.StartOfMonth(), date.EndOfMonth());
        }
    }
}
