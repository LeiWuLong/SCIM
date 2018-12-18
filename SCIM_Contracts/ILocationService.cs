using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCIM_Processor.Models;


namespace SCIM_Contracts
{
    public interface ILocationService
    {
        List<TblLocation> GetLocations();

        TblLocation GetLocationbyId(int locationId);

        void SaveLocation(TblLocation location);

        void UpdateLocation(TblLocation location);

        void DeleteLocation(int locationId);
    }
}
