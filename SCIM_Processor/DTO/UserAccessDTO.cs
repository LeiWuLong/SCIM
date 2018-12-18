using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCIM_Processor.Models;

namespace SCIM_Processor.DTO
{
    public class UserAccessDTO
    {
        [Key]
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public bool IsDeleted { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string FullName { get; set; }
    }
}
