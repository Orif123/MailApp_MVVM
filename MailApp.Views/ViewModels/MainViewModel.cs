using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailApp.ViewModel.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        #region Fields
        private object currentViewModel;
        
        #endregion
        #region Properties
        public object CurrentViewModel
        {
            get { return currentViewModel; }
            set
            {
                currentViewModel = value;
                RaisePropertyChanged(nameof(CurrentViewModel));
            }
        }

        #endregion
        #region Constructor
        public MainViewModel()
        {
            SwitchToMainView();
        }
        #endregion
        #region Methods

        private void SwitchToMainView()
        {
            if (this != null)
                CurrentViewModel = this;
            else
                CurrentViewModel = new MainViewModel();
        }


        #endregion
    }

}

