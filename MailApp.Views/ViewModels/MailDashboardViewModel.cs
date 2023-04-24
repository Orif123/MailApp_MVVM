using GalaSoft.MvvmLight;
using MailApp.Models.Models;
using MailApp.Models.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailApp.ViewModel.ViewModels
{
    public class MailDashboardViewModel : ViewModelBase
    {
        #region Fields
        private readonly IRepository<User> userRepoistory;
        private readonly IRepository<Mail> mailRepository;
        private ObservableCollection<Mail> mails;
        #endregion
        #region CTOR
        public MailDashboardViewModel(IRepository<Mail> mailRepository)
        {
            this.mailRepository = mailRepository;
            var demoMails = mailRepository.GetAll();
            mails = new ObservableCollection<Mail>(demoMails);
        }
        #endregion
        #region Properties

        public ObservableCollection<Mail> Mails
        {
            get { return mails; }
            set { mails = value; RaisePropertyChanged(nameof(Mails)); }
        }


        #endregion

    }
}
