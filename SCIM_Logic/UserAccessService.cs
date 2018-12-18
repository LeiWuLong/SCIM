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
    public class UserAccessService:ILocationSerVice
    {
        SCIMContext dbContext = new SCIMContext();

        UserService userService = new UserService();


        public void SaveUserAccess(TblUserAccess tblUserAccess)
        {
            TblUserAccess access = new TblUserAccess();

            access.UserName = tblUserAccess.UserName;
            access.Password = tblUserAccess.Password;
            access.Attempts = 0;
            access.IsLocked = false;
            access.IsActive = true;
            access.CreatedDate = DateTime.Now.Date;
            access.isDeleted = false;
            access.UserId = tblUserAccess.UserId;

            dbContext.TblUserAccess.Add(access);
            dbContext.SaveChanges();


            
        }

        public TblUserAccess GetUserAccessById(int userId)
        {
            TblUserAccess tblUserAccess = (from p in
                                               dbContext.TblUserAccess
                                           where p.UserId == userId
                                           select p).FirstOrDefault();

            return tblUserAccess;
        }

        public void UpdateUserAccess(TblUserAccess userAccess)
        {
           
                TblUserAccess tblUserAccess = GetUserAccessById(userAccess.UserId);
                tblUserAccess.UserName = userAccess.UserName;
                tblUserAccess.Password = userAccess.Password;


                dbContext.SaveChanges();
                
           
        }

        public void DeleteUserAccess(int userAccessId)
        {
            TblUserAccess tblUserAccess = GetUserAccessById(userAccessId);

            tblUserAccess.isDeleted = true;
            dbContext.SaveChanges();
        }
    }
}
