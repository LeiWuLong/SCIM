using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCIM_Processor;
using SCIM_Contracts;
using SCIM_Processor.DTO;
using SCIM_Processor.Models;

namespace SCIM
{
    public partial class FrmUser : Form
    {
        IUserService _userService;
        ILocationSerVice _userAccessService;
        List<UserAccessDTO> lstUsers;
        int newUserId;

        public FrmUser(IUserService userService,ILocationSerVice userAccessService )
        {
            _userService = userService;
            _userAccessService = userAccessService;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //update user
                TblUser tblUser = new TblUser();
                TblUserAccess tblUserAccess = new TblUserAccess();


                int selectedUser = Convert.ToInt32(cmbUser.SelectedValue);
                tblUser.UserId = selectedUser;
                tblUser.FirstName = txtFirstName.Text.Trim();
                tblUser.MiddleName = txtMiddleName.Text.Trim();
                tblUser.LastName = txtLastName.Text.Trim();

                tblUserAccess.UserName = txtUserName.Text.Trim();
                tblUserAccess.Password = txtPassword.Text.Trim();
                tblUserAccess.UserId=selectedUser;

                _userAccessService.UpdateUserAccess(tblUserAccess);
                _userService.UpdateUser(tblUser);

                MessageBox.Show("User updated successfully");
            }
            catch
            {
                throw;
            }
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbUser_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbUser.SelectedValue)!=0)
            {
                UserAccessDTO selectedUser = _userService.GetUserAccessById(Convert.ToInt32(cmbUser.SelectedValue));

                //cmbUser. = false;
                txtFirstName.Text = selectedUser.FirstName;
                txtMiddleName.Text = selectedUser.MiddleName;
                txtLastName.Text = selectedUser.LastName;
                txtUserName.Text = selectedUser.UserName;

                txtFirstName.Enabled = true;
                txtMiddleName.Enabled = true;
                txtLastName.Enabled = true;
                txtUserName.Enabled = true;
                btnAdd.Hide();
                btnSave.Show();
                //do not fill password field.
            }
            else
            {
                


            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //add user
            try
            {
                TblUser tblUser = new TblUser();
                TblUserAccess tblUserAccess = new TblUserAccess();
                tblUser.FirstName = txtFirstName.Text.Trim();
                tblUser.MiddleName = txtMiddleName.Text.Trim();
                tblUser.LastName = txtLastName.Text.Trim();
                //save user and return id
                newUserId = _userService.SaveUser(tblUser);
                tblUserAccess.UserName = txtUserName.Text.Trim();
                tblUserAccess.Password = txtPassword.Text.Trim();
                tblUserAccess.UserAccessId = newUserId;
                _userAccessService.SaveUserAccess(tblUserAccess);
                MessageBox.Show("User Saved");
            }
            catch(Exception a)    
            {
                throw a;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedUser = Convert.ToInt32(cmbUser.SelectedValue);

                _userService.DeleteUser(selectedUser);
                _userAccessService.DeleteUserAccess(selectedUser);
                ClearForm();

                MessageBox.Show("User successfully deleted");
              
            }
            catch(Exception a)
            {
                throw a;
            }
        }

        public void ClearForm()
        {
            cmbUser.Enabled = true;
            txtFirstName.Enabled = true;
            txtMiddleName.Enabled = true;
            txtLastName.Enabled = true;
            txtUserName.Enabled = true;
            txtPassword.Enabled = true;

            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtLastName.Clear();
            txtUserName.Clear();        
            txtPassword.Clear();

            btnAdd.Show();
            btnSave.Hide();


            //fill uswer combobox

            lstUsers = _userService.GetUsersAccess();
            UserAccessDTO item = new UserAccessDTO();
            item.UserId = 0;
            item.FullName = "---Select User--";

            lstUsers.Add(item);
            cmbUser.DataSource = lstUsers;  // _assessmentService.GetHonors();


            cmbUser.ValueMember = "UserId";
            cmbUser.DisplayMember = "FullName";
            cmbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cmbUser.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbUser.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbUser.SelectedValue = 0;
        }
    }
}
