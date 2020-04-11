using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectWPF.Model
{
    public class Melding : ObservableObject
    {
        private int meldingID;
        private string beschrijving;
        private DateTime datum;
        private int gebruikerID;

        public int MeldingID
        {
            get { return meldingID; }
            set { Set("MeldingID", ref meldingID, value); }
        }

        public string Beschrijving
        {
            get { return beschrijving; }
            set { Set(() => Beschrijving, ref beschrijving, value); }
        }

        public DateTime Datum
        {
            get { return datum; }
            set { Set(() => Datum, ref datum, value); }
        }

        public int GebruikerID
        {
            get { return gebruikerID; }
            set { Set(() => GebruikerID, ref gebruikerID, value); }
        }

        public Melding(int meldingID, string beschrijving, DateTime datum, int gebruikerID)
        {
            MeldingID = meldingID;
            Beschrijving = beschrijving;
            Datum = datum;
            GebruikerID = GebruikerID;
        }

        public Melding() { }

    }
}

