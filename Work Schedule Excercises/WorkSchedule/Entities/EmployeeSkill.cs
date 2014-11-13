using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSchedule.Entities
{
    public class EmployeeSkill
    {
         public enum SkillLevel
        {
            Novice,
            Proficent,
            Expert
        }
        [Key]
        public int EmployeeSkillID { get; set; }
        [Required(ErrorMessage = "Employee ID is required.")]
        public int EmployeeID { get; set; }
        [Required(ErrorMessage = "Skill ID is required.")]
        public int SkillID { get; set; }
        [Required(ErrorMessage = "Level is required.")]
        public SkillLevel Level { get; set; }
        public int? YearsOfExperience { get; set; }

        public virtual Skill Skill { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
