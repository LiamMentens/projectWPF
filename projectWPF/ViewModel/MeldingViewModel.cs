using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using projectWPF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace projectWPF.ViewModel
{
    public class MeldingViewModel : ViewModelBase
    {
        private string beschrijving;
        private DateTime datum;

        private ObservableCollection<Melding> meldingen;
        public ICommand AddMeldingPage { get; private set; }
        public ICommand TerugCommand { get; private set; }

        public MeldingViewModel()
        {
            OphalenMeldingen();
            AddMeldingPage = new RelayCommand(NavigeerAddMeldingPage);
            TerugCommand = new RelayCommand(Terug);

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

        public void NavigeerAddMeldingPage()
        {
            PageNavigationService pageNavigationService = new PageNavigationService();
            pageNavigationService.Navigate("AddMeldingPage");
        }

        public void Terug()
        {
            PageNavigationService pageNavigationService = new PageNavigationService();
            pageNavigationService.Navigate("HomePage");
        }

    }
}
