using System;
using System.Collections.Generic;
using Services.DTO;

namespace Services.IService
{
    public interface IAppointmentService
    {
        IEnumerable<AppointmentDto> GetAppointmetsByDate(DateTime start, DateTime end);

        IEnumerable<AppointmentDto> GetAppointmetsByMonth(int month);
    }
}
