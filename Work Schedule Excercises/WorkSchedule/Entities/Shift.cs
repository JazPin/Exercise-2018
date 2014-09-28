using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSchedule.Entities
{
    public class Shift
    {
        [Key]
        public int ShiftID { get; set; }
        [Required(ErrorMessage = "StartTime is required.")]
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int DayOfWeek { get; set; }
        public int MinEmployees { get; set; }
        public int MaxEmployees { get; set; }
        [Required(ErrorMessage = "LocationID is required.")]
        public int LocationID { get; set; }

        public virtual Location Location { get; set; }
    }
}
