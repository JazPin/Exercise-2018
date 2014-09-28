using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSchedule.Entities
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        [Required(ErrorMessage = "FirstName is required.")]
        [Range(1, 50, ErrorMessage = "FirstName must be between 1 to 50 characters.")]
        public String FirstName { get; set; }
        [Required(ErrorMessage = "LastName is required.")]
        [Range(1, 50, ErrorMessage = "LastName must be between 1 to 50 characters.")]
        public String LastName { get; set; }
        [Required(ErrorMessage = "HomePhone is required.")]
        [Range(1, 12, ErrorMessage = "HomePhone must be between 1 to 12 digits.")]
        public String HomePhone { get; set; }
        [Required(ErrorMessage = "Active is required.")]
        public Boolean Active { get; set; }

        public virtual ICollection<EmployeeLocation> EmployeeLocations { get; set; }
    }
}
