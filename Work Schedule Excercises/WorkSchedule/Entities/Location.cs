using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSchedule.Entities
{
    public class Location
    {
        [Key]
        public int LocationID { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        [Range(1,50,ErrorMessage="Name must be between 1 to 50 characters.")]
        public String Name { get; set; }
        [Required(ErrorMessage = "Street is required.")]
        [Range(1, 50, ErrorMessage = "Street must be between 1 to 50 characters.")]
        public String Street { get; set; }
        [Required(ErrorMessage = "City is required.")]
        [Range(1, 30, ErrorMessage = "City must be between 1 to 20 characters.")]
        public String City { get; set; }
        [Required(ErrorMessage = "Province is required.")]
        [Range(1, 2, ErrorMessage = "Province must be between 1 to 2 characters.")]
        public String Province { get; set; }
        [Required(ErrorMessage = "PhonePhone is required.")]
        [Range(1, 12, ErrorMessage = "Province must be between 1 to 12 digits.")]
        public String Phone { get; set; }
        [Required(ErrorMessage = "Active is required.")]
        public Boolean Active { get; set; }

        public virtual ICollection<EmployeeLocation> EmployeeLocations { get; set; }
        public virtual ICollection<Shift> Shifts { get; set; }
    }
}
