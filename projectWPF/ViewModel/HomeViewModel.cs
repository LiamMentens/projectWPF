using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using projectWPF.Extensions;
using projectWPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace projectWPF.ViewModel
{
    public class HomeViewModel : ObservableObject
    {
        public ICommand MeldingCommand { get; private set; }
        private string emailGebruiker;
        private string welkomBoodschap;
        public HomeViewModel()
        {
            MeldingCommand = new RelayCommand(NavigeerMelding);
            Messenger.Default.Register<string>(this, OnEmailReceived);

        }

        public string WelkomBoodschap
        {
            get { return welkomBoodschap; }
            set { welkomBoodschap = value; RaisePropertyChanged(() => WelkomBoodschap); }
        }

        private void OnEmailReceived(string email)
        {
            GebruikerDataService gebruikerDS = new GebruikerDataService();
            WelkomBoodschap = "Welkom " + email;



        }

        public void NavigeerMelding()
        {
            PageNavigationService pageNavigationService = new PageNavigationService();
            pageNavigationService.Navigate("MeldingPage");
            
        }
    }
}
