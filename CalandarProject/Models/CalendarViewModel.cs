using System.Collections.Generic;

namespace CalandarProject.Models
{
    public class CalendarViewModel
    {
        public Dictionary<int, string> Months { get; set; }

        public int SelectedMonth { get; set; }

        public List<AppointmentViewModel> AppointmentDetails { get; set; }
    }
}