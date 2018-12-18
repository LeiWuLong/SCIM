using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCIM_Contracts;
using SCIM_Processor.Models;
using SCIM_Processor;

namespace SCIM_Logic
{
    public class LoginService:ILoginService
    {
        public TblUserAccess GetUserLogin(string userName, string password)
        {
            using (var dbcontext = new SCIMContext())
            {
                var a = (from p in dbcontext.TblUserAccess
                             where p.UserName == userName
                             && password == p.Password
                             && p.isDeleted == false
                             && p.IsActive == true
                         select p).FirstOrDefault();

                return a;

            }


        }
    }
}
