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
using SCIM_Processor.Models;
using SCIM_Contracts;

namespace SCIM
{
    public partial class FrmLogin : Form 
    {
        TblUserAccess loginAccess;
        private readonly ILoginService _loginService;
        
        public FrmLogin(ILoginService loginService)
        {
            InitializeComponent();
            _loginService = loginService;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //SCIMContext scContext = new SCIMContext();
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var dbcontext = new SCIMContext())
            {
                loginAccess = _loginService.GetUserLogin(txtUsername.Text, txtPassword.Text);
                //var a = (from p in dbcontext.tblUserAccess
                //         where p.UserName == txtUsername.Text
                //         && txtPassword.Text == p.Password
                //         && p.isDeleted != false
                //         select p).FirstOrDefault();

                if (loginAccess != null)
                {


                    this.Hide();
                    var parent = new SCIM_Dashboard();


                   // Global.loggedUserId = loginAccess.UserId;
                    //Global.loggedUserAccess = loginAccess.AccessId;
                    //Parent_SVM parent = new Parent_SVM();
                    parent.Closed += (s, args) => this.Close();


                    parent.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed");
                }


            }








            //SCIM_Dashboard dashboard = new SCIM_Dashboard();
            //dashboard.Closed += (s, args) => this.Close();
            //dashboard.Show();
        }
    }
}
