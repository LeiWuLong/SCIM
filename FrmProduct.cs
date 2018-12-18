using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCIM_Processor.DTO;
using SCIM_Processor;
using SCIM_Processor.Models;
using SCIM_Contracts;

namespace SCIM
{
    public partial class FrmProduct : Form    
    {
        IProductService _productService;
        public FrmProduct(IProductService productService)
        {
            _productService = productService;
            InitializeComponent();
        }

        List<TblProduct> lstProducts = new List<TblProduct>();

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.DeleteProduct(Convert.ToInt32(cmbProductName.SelectedValue));
                MessageBox.Show("Product Successfully Deleted");
                ClearForm();
            }
            catch (Exception a)
            {
                throw a;
            }
        }
            
        private void FrmAddProduct_Load(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void cmbProductName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TblProduct tblProduct = new TblProduct();
            //upon selection
            if (Convert.ToInt16(cmbProductName.SelectedValue) != 0)
            {
                btnAdd.Hide();
                btnSave.Show();
                tblProduct = _productService.GetProductById(Convert.ToInt32(cmbProductName.SelectedValue));

                txtProductCode.Text = tblProduct.ProductCode;
                txtProductDesc.Text = tblProduct.ProductDesc;
                txtProductName.Text = tblProduct.ProductName;
                txtProductPrice.Text = tblProduct.ProductPrice.ToString();

            }
            else
            {
                //if zero, then option to add
                btnAdd.Show();
                btnSave.Hide();

                //clear the fields
                txtProductCode.Clear();
                txtProductDesc.Clear();
                txtProductName.Clear();
                txtProductPrice.Clear();
            }
        }

        private void cmbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            //add new product
            btnAdd.Hide();
            btnSave.Show();
            cmbProductName.Hide();
            txtProductName.Show();

            try
            {
                TblProduct tblProduct = new TblProduct();
                tblProduct.ProductPrice = Convert.ToDouble(txtProductPrice.Text);
                tblProduct.ProductDesc = txtProductDesc.Text;
                tblProduct.ProductName = txtProductName.Text;
                tblProduct.ProductCode = txtProductCode.Text;
                tblProduct.IsDeleted = false;

                if (Convert.ToInt16(cmbProductName.SelectedValue) == 0)
                {
                    //new
                    _productService.SaveProduct(tblProduct);
                    MessageBox.Show("Product Saved!");
                }

                ClearForm();
               
            }
            catch (Exception a)
            {
                throw a;
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
                //update product
            try
            {
               
                TblProduct tblProduct = new TblProduct();
                tblProduct.ProductKey = Convert.ToInt32(cmbProductName.SelectedValue);
                _productService.UpdateProduct(tblProduct);
                MessageBox.Show("Product successfully updated");
                ClearForm();
            }
            catch(Exception a)
            {
                throw a;
            }
        }


        public void ClearForm()
        {
            btnSave.Hide();
            txtProductName.Hide();
            btnAdd.Show();

            //add products dropdown
            lstProducts = _productService.GetProducts();
            TblProduct item = new TblProduct();
            item.ProductDesc = "---Select Product--";
            item.ProductKey = 0;    

            lstProducts.Add(item);
            cmbProductName.DataSource = lstProducts;  


            cmbProductName.ValueMember = "ProductKey";
            cmbProductName.DisplayMember = "ProductDesc";
            cmbProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cmbProductName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbProductName.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbProductName.SelectedValue = 0;


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
