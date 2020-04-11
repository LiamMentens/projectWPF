using projectWPF.View;
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
        Window registratieDetailView = null;
        Window loginDetailView= null;
        public DialogService () { }

        public void ShowRegistratieDetailDialog()
        {
            registratieDetailView = new RegistratieDetailWindow();
            registratieDetailView.ShowDialog();
        }

        public void CloseRegistratieDetailDialog()
        {
            if(registratieDetailView != null)
            {
                registratieDetailView.Close();
            }
        } 
        
        //public void ShowLoginDetailWindow()
        //{
        //    loginDetailView = new LoginDetailWindow();
        //    loginDetailView.ShowDialog();
        //}

        //public void CloseLoginDetailWindow()
        //{
        //    if(loginDetailView != null)
        //    {
        //        loginDetailView.Close();
        //    }
        //}
    }
}
