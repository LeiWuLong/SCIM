using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCIM_Contracts;
using SCIM_Processor.Models;
using SCIM_Processor;
using SCIM_Processor.DTO;

namespace SCIM_Logic
{
    public class UserService:IUserService
    {

        SCIMContext dbContext = new SCIMContext();


        public List<UserAccessDTO> GetUsersAccess()
        {
            List<UserAccessDTO> lstUserAccess = (from p in dbContext.TblUser
                                                 join q in dbContext.TblUserAccess on p.UserId equals q.UserId      
                                            where p.IsDeleted == false
                                            select new UserAccessDTO()
                                            {
                                                UserId = p.UserId,
                                                UserName = q.UserName,
                                                Password = q.Password,
                                                FirstName = p.FirstName,
                                                MiddleName = p.MiddleName,
                                                LastName = p.LastName,
                                                FullName = p.FirstName + " " + p.MiddleName + " " + p.LastName
                                            }).ToList();

            return lstUserAccess;
        }

        public UserAccessDTO GetUserAccessById(int selectedUserId)
        {
            UserAccessDTO userAccessDTO = (from p in dbContext.TblUser
                                           join q in dbContext.TblUserAccess on p.UserId equals q.UserId
                                           where p.IsDeleted == false
                                           select new UserAccessDTO()
                                           {
                                               UserId = p.UserId,
                                               UserName = q.UserName,
                                               Password = q.Password,
                                               FirstName = p.FirstName,
                                               MiddleName = p.MiddleName,
                                               LastName = p.LastName,
                                              // FullName = p.FirstName + " " + p.MiddleName + " " + p.LastName
                                           }).FirstOrDefault();

            return userAccessDTO;
        }

        public int SaveUser(TblUser tblUser)
        {
            dbContext.TblUser.Add(tblUser);
            dbContext.SaveChanges();
            return tblUser.UserId;
        }

        public void UpdateUser(TblUser tblUser)
        {
            TblUser user = GetUserById(tblUser.UserId);
            user.FirstName = tblUser.FirstName;
            user.MiddleName = tblUser.MiddleName;
            user.LastName = tblUser.LastName;

            dbContext.SaveChanges();

        }

        public void DeleteUser(int userId)
        {
            TblUser user = GetUserById(userId);
            user.IsDeleted = true;

            dbContext.SaveChanges();
        }

        //not in interface

        public TblUser GetUserById(int userId)
        {
            //var entity = this.ObjectContext.tblEmployees.FirstOrDefault(row => row.Id == employee.Id);

            //di marunong gumamit bobo!
            TblUser entity = dbContext.TblUser.FirstOrDefault(tblUser => tblUser.UserId == userId);

            return entity;
        }

    }
}
