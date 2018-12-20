using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCIM_Processor.Models;

namespace SCIM_Contracts
{
   public interface IPurchaseOrderService
    {
         List<TblPurchaseOrder> GetPurchaseOrders();

         TblPurchaseOrder GetPurchaseOrderById(int poID);

        List<TblPurchaseOrderDetails> GetPurchaseOrderDetails(int poID);
    }
}
