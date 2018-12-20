using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCIM_Processor.Models
{
    public class TblProduct
    {
        [Key]
        public int ProductKey { get; set; }

        public string ProductName { get; set; }

        public string ProductDesc { get; set; }

        public double ProductPrice { get; set; }

        public string ProductCode { get; set; }

        public int ProductQuantity { get; set; }

        public bool IsDeleted { get; set; }

        public int LocationId { get; set; }
    }
}
