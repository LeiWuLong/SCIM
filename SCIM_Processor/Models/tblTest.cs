using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCIM_Processor.Models
{
    public partial class TblTest
    {
        [Key]
        public int TestKey { get; set; }
    }
}
