using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using CRM_Office.Interface;

namespace CRM_Office.Controller
{
    public class MainController
    {
        private static MainController _instance;
        public static MainController Instance => _instance ?? (_instance = new MainController());

        private readonly MainWindow mainWindow;
        private readonly Frame FrameBox;

        public MainController()
        {
            mainWindow = new MainWindow();
            mainWindow.Show();

            FrameBox = mainWindow.frameBox;
        }

        public void ViewPage(IController pageController)
        {
            pageController.ViewInPage(FrameBox);
        }

        public void ViewLogin()
        {
            LoginController loginController = new LoginController();
            loginController.View();
        }
    }
}
