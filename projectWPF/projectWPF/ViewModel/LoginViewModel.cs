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
    public class LoginViewModel : ViewModelBase
    {
        private string email;
        private string wachtwoord;
        public ICommand LoginCommand { get; private set; }

        private DialogService dialogService;

        public string Wachtwoord
        {
            get { return wachtwoord; }
            set { wachtwoord = value; RaisePropertyChanged(() => Wachtwoord); }
        }
        public string Email
        {
            get { return email; }
            set { email = value; RaisePropertyChanged(() => Email); }
        }

        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(Login);
            dialogService = new DialogService();
        }

        public void Login()
        {
            GebruikerDataService gebruikerDS = new GebruikerDataService();
            List<Gebruiker> lijst = gebruikerDS.GetGebruikers();

            if (lijst.Any(l => l.Email == Email) && lijst.Any(l => l.Wachtwoord == Wachtwoord))
            {
                Messenger.Default.Send<string>("Ingelogd!");
            }
            else
            {
                Messenger.Default.Send<string>("Gegevens zijn niet correct");
            }
            dialogService.ShowRegistratieDetailDialog();

        }
    }
}
