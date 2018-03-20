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
    public class CustomerController : IController
    {
        private readonly CustomerPage customerPage;

        public CustomerController()
        {
            customerPage = new CustomerPage(this);
        }

        public void View()
        {
            throw new System.NotImplementedException();
        }

        public void ViewInPage(Frame frameOfPage)
        {
            frameOfPage.Navigate(customerPage);
        }
    }
}
