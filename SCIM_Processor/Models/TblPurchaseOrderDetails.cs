using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCIM_Processor.Models
{
    public class TblPurchaseOrderDetails
    {
        [Key]
        public int PurchaseOrderDetailsId { get; set; }

        public int PurchaseOrderId { get; set; }

        public string POCode { get; set; }

        public DateTime CreatedDate { get; set; }

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public float TotalPurchaseCost { get; set; }

        public bool IsDeleted { get; set; }

        public string Customer { get; set; }

        public int Quantity { get; set; }

    }
}
