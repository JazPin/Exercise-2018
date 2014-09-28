using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSchedule.Entities
{
    public class EmployeeLocation
    {
        [Key, Column(Order = 1)]
        public int EmployeeID { get; set; }
        [Key, Column(Order = 2)]
        public int LocationID { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Location Location { get; set; }
             
    }
}
