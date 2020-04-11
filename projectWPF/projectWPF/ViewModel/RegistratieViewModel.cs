﻿using GalaSoft.MvvmLight;
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
    public class RegistratieViewModel : ViewModelBase
    {
        private string gebruikersnaam;
        private string wachtwoord;
        private string email;

        private DialogService dialogService;

        public ICommand InsertGebruikerCommand { get; private set; }

        public string Gebruikersnaam
        {
            get { return gebruikersnaam; }
            set { gebruikersnaam = value; RaisePropertyChanged(() => Gebruikersnaam); }
        }

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

        public RegistratieViewModel()
        {
            InsertGebruikerCommand = new RelayCommand(ToevoegenGebruiker);
            dialogService = new DialogService();
        }

        private void ToevoegenGebruiker()
        {
            GebruikerDataService gebruikerDS = new GebruikerDataService();
            List<Gebruiker> lijst = gebruikerDS.GetGebruikers();
            if (Gebruikersnaam == null || Wachtwoord == null || Email == null)
            {
                if(lijst.Any(g=> g.Email == Email))
                {
                    Messenger.Default.Send<string>("Vul alle gegevens in \n Deze email is al in gebruik" );
                }
                else
                {
                    Messenger.Default.Send<string>("Vul alle gegevens in");
                }
                dialogService.ShowRegistratieDetailDialog();
            }
            else
            {
                Gebruiker nieuwGebruiker = new Gebruiker(Gebruikersnaam, Wachtwoord, Email);
                gebruikerDS.InsertGebruiker(nieuwGebruiker);

                Messenger.Default.Send<string>("Account aangemaakt!");
                dialogService.ShowRegistratieDetailDialog();
            }
        }

      
     
    }
}
