using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Appointment : BaseEntity
    {
        public Appointment()
        {
            Attendees = new List<User>();
        }
        public DateTime AppointmentDateTime { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(4000)]
        public string Description { get; set; }

        public long OrganizerId { get; set; }

        [ForeignKey(nameof(OrganizerId))]
        public User Organizer { get; set; }

        public virtual ICollection<User> Attendees { get; set; }
    }
}
