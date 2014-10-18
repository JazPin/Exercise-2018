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
        public Location()
        {
            Active = true;
        }

        [Key]
        public int LocationID { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Name must be between 1 to 50 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Street is required.")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Street must be between 1 to 50 characters.")]
        public string Street { get; set; }

        [Required(ErrorMessage = "City is required.")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "City must be between 1 to 20 characters.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Province is required.")]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "Province must be 2 characters.")]
        public string Province { get; set; }

        
        [StringLength(50, MinimumLength = 0, ErrorMessage = "Contact must be between 1 to 50 characters.")]
        public string Contact { get; set; }

        [Required(ErrorMessage = "PhonePhone is required.")]
        [StringLength(12, MinimumLength = 12, ErrorMessage = "Phone must be 12 characters.")]
        //[RegularExpression(@"[1-9][0-9][0-9][0-9].[[0-9][0-9][0-9].[0-9][0-9][0-9][0-9]")]
        public string Phone { get; set; }

        //[Required(ErrorMessage = "Active is required.")]
        public bool Active { get; set; }

        public virtual ICollection<EmployeeLocation> EmployeeLocations { get; set; }
        public virtual ICollection<Shift> Shifts { get; set; }
    }
}
