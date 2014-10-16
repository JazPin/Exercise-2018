using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkSchedule.DAL;
using WorkSchedule.Entities;

namespace WorkSchedule.BLL
{
    [DataObject]
    public class LocationController
    {
        #region Manage Waiters
        #region Command
        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public int AddLocation(Location item)
        {
            using (WorkScheduleContext context = new WorkScheduleContext())
            {
                // Validation of waiter data
                var added = context.Locations.Add(item);
                context.SaveChanges();
                return added.LocationID;
            }
        }
        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void UpdateLocation(Location item)
        {
            using (WorkScheduleContext context = new WorkScheduleContext())
            {
                // Validation
                var attatched = context.Locations.Attach(item);
                var matchingWithExistingValues = context.Entry<Location>(attatched); // Lookup info about a object in the database
                matchingWithExistingValues.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public void DeleteLocation(Location item)
        {
            using (WorkScheduleContext context = new WorkScheduleContext())
            {
                var existing = context.Locations.Find(item.LocationID);
                context.Locations.Remove(existing);
                context.SaveChanges();
            }
        }
        #endregion
        #region Query
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Location> ListAllLocations()
        {
            using (WorkScheduleContext context = new WorkScheduleContext())
            {
                return context.Locations.ToList();
            }
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Location GetLocation(int locationId)
        {
            using (WorkScheduleContext context = new WorkScheduleContext())
            {
                return context.Locations.Find(locationId);
            }
        }
        #endregion
        #endregion
    }
}
