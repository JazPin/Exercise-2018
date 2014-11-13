using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkSchedule.DAL;
using WorkSchedule.Entities.POCOs;

namespace WorkSchedule.BLL
{
    [DataObject]
    public class EmployeeSkillDirectoryReport
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<EmployeeSkillDirectory> GetEmployeeSkillDirectory()
        {
            using(var context = new WorkScheduleContext())
            {
                var result = from item in context.EmployeeSkills
                             orderby item.Skill.Description
                             select new EmployeeSkillDirectory()
                             {
                                 Skill = item.Skill.Description,
                                 Name = item.Employee.FirstName + " " + item.Employee.LastName,
                                 Phone = item.Employee.HomePhone,
                                 Level = item.Level.ToString(),
                                 YOE = item.YearsOfExperience
                             };
                return result.ToList();
            }
        }
    }
}
