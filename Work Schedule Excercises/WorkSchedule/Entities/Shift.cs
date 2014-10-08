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
        public TimeSpan StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public byte? DayOfWeek { get; set; }
        public byte? MinEmployees { get; set; }
        public byte? MaxEmployees { get; set; }
        [Required(ErrorMessage = "LocationID is required.")]
        public int LocationID { get; set; }

        public virtual Location Location { get; set; }
    }
}
