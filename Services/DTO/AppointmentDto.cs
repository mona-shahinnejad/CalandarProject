using System;
using System.Collections.Generic;

namespace Services.DTO
{
    public class AppointmentDto
    {
        public long Id { get; set; }

        public DateTime AppointmentDateTime { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public long OrganizerId { get; set; }

        public string OrganizerFullName { get; set; }

        public IEnumerable<UserDto> Attendees { get; set; }
    }
}
