using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WorkSchedule.Entities;

namespace WorkSchedule.DLL
{
    class WorkScheduleContext : DbContext
    {
        public WorkScheduleContext() : base("name=WorkSchedule"){ }

        #region Table to Entity mappings
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<EmployeeLocation> EmployeeLocations { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        #endregion
    }
}
