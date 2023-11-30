using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Viewers.Stores;
using Viewers.ViewModels;

namespace Viewers.Commands
{
    public class OpenAddYoutubeViewerCommand : CommandBase
    {
        private readonly ModalNavigationStore _modalNavigationStore;

        public OpenAddYoutubeViewerCommand(ModalNavigationStore modalNavigationStore)
        {
            _modalNavigationStore = modalNavigationStore;
        }

        public override void Execute(object? parameter)
        {
            AddYoutubeViewerViewViewModel addYoutubeViewerViewViewModel = new AddYoutubeViewerViewViewModel(_modalNavigationStore);
            _modalNavigationStore.CurrentViewModel = addYoutubeViewerViewViewModel;  
        }
    }
}
