using GalaSoft.MvvmLight;
using projectWPF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectWPF.ViewModel
{
    public class MeldingViewModel : ViewModelBase
    {
        private string beschrijving;
        private DateTime datum;

        private ObservableCollection<Melding> meldingen;

        public MeldingViewModel()
        {
            OphalenMeldingen();

        }

        public string Beschrijving
        {
            get { return beschrijving; }
            set { beschrijving = value; RaisePropertyChanged(() => Beschrijving);}
        }

       public DateTime Datum
        {
            get { return datum; }
            set { datum = value; RaisePropertyChanged(() => Datum); }
        }

        public ObservableCollection<Melding> Meldingen
        {
            get { return meldingen; }
            set { meldingen = value; }

        }

        private void OphalenMeldingen()
        {
            MeldingDataService meldingDS = new MeldingDataService();
            Meldingen = new ObservableCollection<Melding>(meldingDS.GetMeldingen());
            RaisePropertyChanged(() => Meldingen);
        }

    }
}
