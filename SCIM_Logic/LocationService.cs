using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCIM_Processor.Models;
using SCIM_Processor;
using SCIM_Contracts;

namespace SCIM_Logic
{
    public class LocationService:ILocationService
    {
        SCIMContext dbContext = new SCIMContext();

        public List<TblLocation> GetLocations()
        {
            List<TblLocation> lstLocations = dbContext.TblLocation.Where(p => p.isDeleted == false).ToList();

            return lstLocations;
        }

        public TblLocation GetLocationbyId(int locationId)
        {
            TblLocation location = dbContext.TblLocation.FirstOrDefault(p => p.isDeleted == false && p.LocationId == locationId);

            return location;
        }

        public void SaveLocation(TblLocation location)
        {
            dbContext.TblLocation.Add(location);
            dbContext.SaveChanges();
        }


        public void UpdateLocation(TblLocation location)
        {
            TblLocation updateLocation = GetLocationbyId(location.LocationId);
            updateLocation.LocationName = location.LocationName;
            dbContext.SaveChanges();
        }

        public void DeleteLocation(int locationId)
        {
            TblLocation updateLocation = GetLocationbyId(locationId);
            updateLocation.isDeleted = true;
            dbContext.SaveChanges();
        }
    }
}
