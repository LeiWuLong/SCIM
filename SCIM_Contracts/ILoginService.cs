using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCIM_Processor.Models;

namespace SCIM_Contracts
{
    public interface ILoginService
    {
       TblUserAccess GetUserLogin(string Username, string Password);
       
    }
}
