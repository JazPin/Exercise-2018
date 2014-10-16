﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSchedule.Entities
{
    public class EmployeeSkill
    {
        [Key]
        public int EmployeeSkillID { get; set; }
        [Required(ErrorMessage = "Employee ID is required.")]
        public int EmployeeID { get; set; }
        [Required(ErrorMessage = "Skill ID is required.")]
        public int SkillID { get; set; }
        [Required(ErrorMessage = "Level is required.")]
        public int Level { get; set; }
        public int YearOfExperience { get; set; }

        public virtual Skill Skill { get; set; }
        public virtual Employee Employee { get; set; }
    }
}