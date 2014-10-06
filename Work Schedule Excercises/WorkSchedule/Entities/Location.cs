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
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Name must be between 1 to 50 characters.")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Street is required.")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Street must be between 1 to 50 characters.")]
        public String Street { get; set; }

        [Required(ErrorMessage = "City is required.")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "City must be between 1 to 20 characters.")]
        public String City { get; set; }

        [Required(ErrorMessage = "Province is required.")]
        [StringLength(2, MinimumLength = 1, ErrorMessage = "Province must be 2 characters.")]
        public String Province { get; set; }

        [Required(ErrorMessage = "PhonePhone is required.")]
        [RegularExpression(@"[1-9][0-9][0-9][0-9].[[0-9][0-9][0-9].[0-9][0-9][0-9][0-9]")]
        public String Phone { get; set; }

        [Required(ErrorMessage = "Active is required.")]
        public Boolean Active { get; set; }

        public virtual ICollection<EmployeeLocation> EmployeeLocations { get; set; }
        public virtual ICollection<Shift> Shifts { get; set; }
    }
}
