using projectWPF.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectWPF.Model
{
    public class PageNavigationService
    {
        HomePage home = null;
        MeldingPage melding = null;
        AddMeldingPage addMeldingPage = null;
        public PageNavigationService()
        {

        }

        public void Navigate(string page)
        {
            switch (page)
            {
                case "HomePage":
                    home = new HomePage();
                    ApplicationHelper.NavigationService.Navigate(home);
                    break;
                case "MeldingPage":
                    melding = new MeldingPage();
                    ApplicationHelper.NavigationService.Navigate(melding);
                    break;
                case "AddMeldingPage":
                    addMeldingPage = new AddMeldingPage();
                    ApplicationHelper.NavigationService.Navigate(addMeldingPage);
                    break;
                //case "AddMeldingPage":
                //    addMeldingPage = new AddMeldingPage();
                //    ApplicationHelper.NavigationService.Navigate(addMeldingPage);
                //    break;
                default:
                    break;
            }
        }


    }
}
