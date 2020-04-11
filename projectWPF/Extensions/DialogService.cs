using projectWPF.View;
using projectWPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace projectWPF.Extensions
{
    class DialogService
    {
        Window popupWindow = null;
        Window mainWindow = null;
        Window loginWindow = null;
        Window registratieWindow = null;
        public DialogService () { }

        public void ShowPopupWindow()
        {
            popupWindow = new PopupWindow();
            popupWindow.ShowDialog();
        }

        public void ClosePopupWindow()
        {
            if(popupWindow != null)
            {
                popupWindow.Close();
            }
        }

        public void ShowMainWindow()
        {
            mainWindow = new MainWindow();
            mainWindow.ShowDialog();
        }


        public void CloseMainWindow()
        {
            if (mainWindow != null)
            {
                mainWindow.Close();
            }
        }

        public void ShowLoginWindow()
        {
            loginWindow = new LoginWindow();
            loginWindow.ShowDialog();
        }


        public void CloseLoginWindow()
        {
            if(loginWindow != null)
            {
                loginWindow.Close();
            }
        }

        public void ShowRegistratieWindow()
        {
            registratieWindow = new RegistratieWindow();
            registratieWindow.ShowDialog();
        }


        public void CloseRegistratieWindow()
        {
            if (registratieWindow != null)
            {
                registratieWindow.Close();
            }
        }


    }
}
