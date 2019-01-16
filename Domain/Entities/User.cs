using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class User : BaseEntity
    {
        [StringLength(25)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [NotMapped]
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        [EmailAddress]
        [StringLength(200)]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [StringLength(25)]
        public string Password { get; set; }

        public bool IsActive { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }

        public virtual ICollection<Appointment> Appointments_Attendees { get; set; }
    }
}
