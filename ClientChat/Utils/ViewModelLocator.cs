using ClientChat.Services;
using ClientChat.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace ClientChat.Utils
{
    public class ViewModelLocator
    {
        private UnityContainer container;
        public ViewModelLocator()
        {
            container = new UnityContainer();
            container.RegisterType<IChatService, ChatService>();
            container.RegisterType<IDialogService, DialogService>();
        }
        public MainWindowViewModel MainVM
        {
            get { return container.Resolve<MainWindowViewModel>(); }
        }
    }
}
