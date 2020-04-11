using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectWPF.Model
{
    class Gebruiker : ObservableObject
    {
        private int gebruikerID;
        private string gebruikersnaam;
        private string wachtwoord;
        private string email;

        public int GebruikerID
        {
            get { return gebruikerID; }
            set { Set("GebruikerID", ref gebruikerID, value); }
        }

        public string Gebruikersnaam
        {
            get { return gebruikersnaam; }
            set { Set(() => Gebruikersnaam, ref gebruikersnaam, value); }
        }

        public string Wachtwoord
        {
            get { return wachtwoord; }
            set { Set(() => Wachtwoord, ref wachtwoord, value); }
        }

        public string Email
        {
            get { return email; }
            set { Set(() => Email, ref email, value); }
        }

        public Gebruiker(string gebruikersnaam, string wachtwoord, string email)
        {
            Gebruikersnaam = gebruikersnaam;
            Wachtwoord = wachtwoord;
            Email = email;
        }

        public Gebruiker() { }

    }
}

