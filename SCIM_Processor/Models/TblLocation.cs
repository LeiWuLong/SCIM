using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCIM_Processor.Models
{
    public class TblLocation
    {
        [Key]
        public int LocationId { get; set; }

        public string LocationName { get; set; }    

        public bool isDeleted { get; set; }
    }
}
