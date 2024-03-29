﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSchedule.Entities
{
    public class Schedule
    {
        [Key]
        public int ScheduleID { get; set; }
        [Required(ErrorMessage="Shift ID is required.")]
        public int ShiftID { get; set; }
        [Required(ErrorMessage = "Employee ID is required.")]
        public int EmployeeID { get; set; }
        [Required(ErrorMessage = "Day is required.")]
        public DateTime Day { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Shift Shift { get; set; }

    }
}
