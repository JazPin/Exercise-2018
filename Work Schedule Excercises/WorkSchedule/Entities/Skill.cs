using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSchedule.Entities
{
    public class Skill
    {
        [Key]
        public int SkillID { get; set; }
        [Required(ErrorMessage = "Description is required.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Description must be between 1 to 100 characters.")]
        public string  Description { get; set; }
        public bool RequiresTicket { get; set; }

        public virtual ICollection<EmployeeLocation> EmployeeLocations { get; set; }
    }
}
