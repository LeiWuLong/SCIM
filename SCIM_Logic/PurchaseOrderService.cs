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
    public class PurchaseOrderService : IPurchaseOrderService
    {
        SCIMContext dbContext = new SCIMContext();

        public List<TblPurchaseOrder> GetPurchaseOrders()
        {
            List<TblPurchaseOrder> lstPurchaseOrders = dbContext.TblPurchaseOrder.Where(p => p.IsDeleted == false).ToList();
            return lstPurchaseOrders;
        }

        public TblPurchaseOrder GetPurchaseOrderById(int poID)
        {
            TblPurchaseOrder purchaseOrder = (from p in dbContext.TblPurchaseOrder
                                              where p.IsDeleted == false && p.PurchaseOrderId == poID
                                              select p).FirstOrDefault();

            return purchaseOrder;
        }

        public List<TblPurchaseOrderDetails> GetPurchaseOrderDetails(int poID)
        {
            List<TblPurchaseOrderDetails> purchaseOrderDetails = (from p in dbContext.TblPurchaseOrderDetails
                                              where p.IsDeleted == false && p.PurchaseOrderId == poID
                                              select p).ToList();

            return purchaseOrderDetails;
        }
    }
}
