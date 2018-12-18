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
    public partial class FrmLocation : Form
    {
        //test second commit
        ILocationService _locationService;
        List<TblLocation> lstLocation = new List<TblLocation>();

        public FrmLocation(ILocationService locationService)
        {
            _locationService = locationService;
            InitializeComponent();

        }

        public void ClearForm()
        {
            btnAdd.Show();
            btnSave.Hide();

            //load combobox
            lstLocation = _locationService.GetLocations();
            TblLocation item = new TblLocation();
            item.LocationName = "---Select Location--";
            item.LocationId = 0;

            lstLocation.Add(item);
            cmbLocation.DataSource = lstLocation;


            cmbLocation.ValueMember = "LocationId";
            cmbLocation.DisplayMember = "LocationName";
            cmbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cmbLocation.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbLocation.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbLocation.SelectedValue = 0;
            //till here

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                TblLocation tblLocation = new TblLocation();

                tblLocation.LocationName = txtLocationName.Text.Trim();
                tblLocation.LocationId = Convert.ToInt32(cmbLocation.SelectedValue);
                _locationService.UpdateLocation(tblLocation);

                MessageBox.Show("Location Successfuly Updated");
            }
            catch(Exception a)
            {
                throw a;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                TblLocation tblLocation = new TblLocation();

                tblLocation.LocationName = txtLocationName.Text.Trim();
                _locationService.SaveLocation(tblLocation);

                MessageBox.Show("Location Successfully Saved");

            }
            catch (Exception a)
            {
                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int locationId;
                locationId = Convert.ToInt32(cmbLocation.SelectedValue);
                _locationService.DeleteLocation(locationId);
                txtLocationName.Clear();

                MessageBox.Show("Location Deleted");
                ClearForm();

            }
            catch (Exception a)
            {

            }
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void cmbLocation_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TblLocation selectedLocation = new TblLocation();

            selectedLocation = _locationService.GetLocationbyId(Convert.ToInt32(cmbLocation.SelectedValue));
            txtLocationName.Text = selectedLocation.LocationName.Trim();

        }
    }
}
