using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCIM_Processor.DTO;
using SCIM_Processor.Models;

namespace SCIM_Contracts
{
    public interface IUserService
    {
        List<UserAccessDTO> GetUsersAccess();

       UserAccessDTO GetUserAccessById(int selectedUserId);

        int SaveUser(TblUser userAccessDTO);

        void UpdateUser(TblUser tblUser);

        void DeleteUser(int userId);

        TblUser GetUserById(int userId);
    }
}
