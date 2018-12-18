using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCIM_Processor.Models;


namespace SCIM_Contracts
{
    public interface ILocationSerVice
    {
        void SaveUserAccess(TblUserAccess tblUserAccess);

        void UpdateUserAccess(TblUserAccess tblUserAccess);

        //get access by user id.
        TblUserAccess GetUserAccessById(int userId);

        void DeleteUserAccess(int userAccessId);
    }
}
