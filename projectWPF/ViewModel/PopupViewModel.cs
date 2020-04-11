using GalaSoft.MvvmLight;
using projectWPF.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectWPF.ViewModel
{
    public class PopupViewModel : ViewModelBase
    {
        private string message;
        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
                RaisePropertyChanged(() => Message);
            }
        }

        public PopupViewModel()
        {
            Messenger.Default.Register<string>(this, OnMessageReceived);
        }

        private void OnMessageReceived(string bericht)
        {
            Message = bericht;
        }

    }
}
