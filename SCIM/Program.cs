using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCIM_Contracts;
using SCIM_Logic;

namespace SCIM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ILoginService _loginService = new LoginService();
            Application.Run(new FrmLogin(_loginService));
        }
    }
}
