using Autofac;
using MailApp.Models.Data;
using MailApp.Models.Models;
using MailApp.Models.Service;
using MailApp.ViewModel.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailApp.Views.ViewModels
{
    public class ViewModelLocator
    {
        private static readonly IContainer container;
        private readonly DemoDataContext demoDataContext;
        static ViewModelLocator()
        {
            DemoDataContext dc = new DemoDataContext();
            var mails = dc.Mails;
            var builder = new ContainerBuilder();
            builder.RegisterInstance<ObservableCollection<Mail>>(mails).SingleInstance();
            builder.RegisterType<Repository<Mail>>().As<IRepository<Mail>>().SingleInstance();
            builder.RegisterType<MailDashboardViewModel>().SingleInstance();

            container = builder.Build();
        }
        public MailDashboardViewModel MailDashboardViewModel => container.Resolve<MailDashboardViewModel>();
    }
}
