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
        public Shift()
        {
            Active = true;
        }
        [Key]
        public int ShiftID { get; set; }
        [Required(ErrorMessage = "PlacementContactID is required.")]
        public int PlacementContactID { get; set; }
        [Required(ErrorMessage = "StartTime is required.")]
        public TimeSpan StartTime { get; set; }
        [Required(ErrorMessage = "EndTime is required.")]
        public TimeSpan EndTime { get; set; }
        [Required(ErrorMessage = "DayOfWeek is required.")]
        public byte DayOfWeek { get; set; }
        [Required(ErrorMessage = "NumberOfEmployees is required.")]
        public byte NumberOfEmployees { get; set; }
        public bool Active { get; set; }
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Note must be between 1 to 100 characters.")]
        public string Note { get; set; }

        public virtual PlacementContact PlacementContact { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
