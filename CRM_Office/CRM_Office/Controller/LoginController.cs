using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using CRM_Office.Interface;
using CRM_Office.View;

namespace CRM_Office.Controller
{
    public class LoginController : IController
    {
        private LoginWindow loginWindow;

        public void View()
        {
            loginWindow = new LoginWindow(this);
            loginWindow.ShowDialog();
        }

        public void ViewInPage(Frame frameOfPage)
        {
            throw new Exception("Cannot open the login in-page.");
        }
    }
}
