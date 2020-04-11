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
    public class AddMeldingViewModel : ViewModelBase
    {
        private string beschrijving;
        private DateTime datum;

        private DialogService dialogService;

        public ICommand InsertMeldingCommand { get; private set; }
        public ICommand TerugCommand { get; private set; }

        private Gebruiker currentGebruiker;

        public string Beschrijving
        {
            get { return beschrijving; }
            set { beschrijving = value; RaisePropertyChanged(() => Beschrijving); }
        }

        public DateTime Datum
        {
            get { return datum; }
            set { datum = value; RaisePropertyChanged(() => Datum); }
        }

        //public Gebruiker CurrentGebruiker
        //{
        //    get { return currentGebruiker; }
        //    set { currentGebruiker = value; RaisePropertyChanged("CurrentGebruiker"); }
        //}

        public AddMeldingViewModel()
        {
            InsertMeldingCommand = new RelayCommand(ToevoegenMelding);
            TerugCommand = new RelayCommand(Terug);
            dialogService = new DialogService();
        }

        public void ToevoegenMelding()
        {
            MeldingDataService meldingDS = new MeldingDataService();
            List<Melding> lijst = meldingDS.GetMeldingen();

            Melding nieuwMelding = new Melding(beschrijving, datum, 1);
            meldingDS.InsertMelding(nieuwMelding);
            dialogService.ShowPopupWindow();
            Messenger.Default.Send<string>("Melding toegevoegd!");

        }

        public void Terug()
        {
            PageNavigationService pageNavigationService = new PageNavigationService();
            pageNavigationService.Navigate("MeldingPage");
        }

    }
}
