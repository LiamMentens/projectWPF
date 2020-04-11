using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectWPF.Model
{
    class Locatie : ObservableObject
    {
        private int locatieID;
        private string gemeente;
        private string postcode;
        private string straat;
        private string provincie;
        private int meldingID;

        public int LocatieID
        {
            get { return locatieID; }
            set { Set("LocatieID", ref locatieID, value); }
        }

        public string Gemeente
        {
            get { return postcode; }
            set { Set(() => Gemeente, ref gemeente, value); }
        }


        public string Postcode
        {
            get { return postcode; }
            set { Set(() => Postcode, ref postcode, value); }
        }

        public string Straat
        {
            get { return straat; }
            set { Set(() => Straat, ref straat, value); }
        }

        public string Provincie
        {
            get { return provincie; }
            set { Set(() => Provincie, ref provincie, value); }
        }

        public int MeldingID
        {
            get { return meldingID; }
            set { Set(() => MeldingID, ref meldingID, value); }
        }

        public Locatie(int locatieID, string gemeente, string postcode, string straat, string provincie, int meldingID)
        {
            LocatieID = locatieID;
            Gemeente = gemeente;
            Postcode = postcode;
            Straat = straat;
            Provincie = provincie;
            MeldingID = meldingID;
        }
        public Locatie() { }


    }
}
