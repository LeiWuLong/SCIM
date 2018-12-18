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
    public class ProductService : IProductService
    {

        SCIMContext dbContext = new SCIMContext();


        public List<TblProduct> GetProducts()
        {


            List<TblProduct> lstProducts = (from p in dbContext.TblProduct
                                            where p.IsDeleted == false
                                            select p).ToList();

            return lstProducts;

        }

        public TblProduct GetProductById(int productKey)
        {
            TblProduct lstProductById = (from p in dbContext.TblProduct
                                         where p.IsDeleted == false
                                         && p.ProductKey == productKey
                                         select p).FirstOrDefault();
            return lstProductById;
        }

        public void SaveProduct(TblProduct tblProduct)
        {

            dbContext.TblProduct.Add(tblProduct);
            dbContext.SaveChanges();


        }

        public void UpdateProduct(TblProduct updatedProduct)
        {
            TblProduct product = GetProductById(updatedProduct.ProductKey);

            dbContext.Entry(product).CurrentValues.SetValues(updatedProduct);
            dbContext.SaveChanges();
        }

        public void DeleteProduct(int productId)
        {
            TblProduct lstProductById = GetProductById(productId);
            lstProductById.IsDeleted = true;
            dbContext.SaveChanges();
        }
    }
}



    

