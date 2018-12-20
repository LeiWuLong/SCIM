using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCIM_Contracts;
using SCIM_Processor.Models;

namespace SCIM
{   
    public partial class FrmPurchaseOrder : Form
    {
        IPurchaseOrderService _purchaseOrderService;
        IProductService _productService;
        List<TblPurchaseOrder> lstPurchaseOrder = new List<TblPurchaseOrder>();

        public FrmPurchaseOrder(IPurchaseOrderService purchaseOrderService, IProductService productService)
        {
            _purchaseOrderService = purchaseOrderService;
            _productService = productService;
            InitializeComponent();
        }

        private void FrmPurchaseOrder_Load(object sender, EventArgs e)
        {
            ClearForm();
        }

        public void ClearForm()
        {
            btnAdd.Show();
            btnSave.Hide();

            //load combobox
            lstPurchaseOrder = _purchaseOrderService.GetPurchaseOrders();
            TblPurchaseOrder item = new TblPurchaseOrder();
            item.PurchaseOrderCode = "---Select PO--";
            item.PurchaseOrderId = 0;

            lstPurchaseOrder.Add(item);
            cmbPurchaseOrder.DataSource = lstPurchaseOrder;


            cmbPurchaseOrder.ValueMember = "PurchaseOrderId";
            cmbPurchaseOrder.DisplayMember = "PurchaseOrderCode";
            cmbPurchaseOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cmbPurchaseOrder.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbPurchaseOrder.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbPurchaseOrder.SelectedValue = 0;
            //till here
            BindOtherPurchases(0);

        }

        public void BindOtherPurchases(int inquiryId)
        {
            dgvProducts.DataSource = null;
            dgvProducts.Rows.Clear();
            dgvProducts.Columns.Clear();
             List<TblPurchaseOrder> lstPurchaseOrders = _purchaseOrderService.GetPurchaseOrders();
            if (lstPurchaseOrders.Count == 0)
            {
                lstPurchaseOrders = _purchaseOrderService.GetPurchaseOrders();
            }

               var purchaseOrderBindingList = new BindingList<TblPurchaseOrder>(lstPurchaseOrder);
                var purchaseOrderSource = new BindingSource(purchaseOrderBindingList, null);

                //bind combobox
                DataGridViewComboBoxColumn cmbItem = new DataGridViewComboBoxColumn();
            // DataGridViewColumn cmbLevel = new DataGridViewColumn(bc);
            //cmbRelation.Items.Insert(0, String.Empty);
            List<TblProduct> lstProduct = _productService.GetProducts();
           // lstPurchaseOrderDetails.Insert(0, new TblPurchaseOrderDetails { ProductId = 0, ProductName = "Select Product" });
            cmbItem.DataSource = lstProduct;
            cmbItem.ValueMember = "ProductKey";
            cmbItem.DisplayMember = "ProductName";
            
            //cmbItem.DataPropertyName = "OtherPurchasesId";

            dgvProducts.AutoGenerateColumns = false;
            if (dgvProducts.DataSource == null)
            {
                dgvProducts.ColumnCount = 3;

            }

            dgvProducts.Columns.Insert(0, cmbItem);
            dgvProducts.Columns[0].Name = "colDesc";
            dgvProducts.Columns[0].HeaderText = "Item";

            dgvProducts.Columns[0].Name = "colProductName";
            dgvProducts.Columns[0].HeaderText = "Product Name";
            dgvProducts.Columns[0].DataPropertyName = "ProductName";

            dgvProducts.Columns[1].Name = "colProductDesc";
            dgvProducts.Columns[1].HeaderText = "Product Description";
            dgvProducts.Columns[1].DataPropertyName = "ProductDesc";

            dgvProducts.Columns[2].Name = "colProductCode";
            dgvProducts.Columns[2].HeaderText = "Product Code";
            dgvProducts.Columns[2].DataPropertyName = "ProductCode";

            dgvProducts.Columns[0].Width = 100;
            dgvProducts.Columns[1].Width = 200;
            dgvProducts.Columns[2].Width = 70;

            if (inquiryId != 0)
            {
               // dgvProducts.DataSource = lst;
            }
            // dgvProducts.Columns[0].Visible = false;
            
        }
    }
}
