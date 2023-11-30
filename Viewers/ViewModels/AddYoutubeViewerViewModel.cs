using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Viewers.Commands;
using Viewers.Stores;

namespace Viewers.ViewModels
{
    public class AddYoutubeViewerViewViewModel  :ViewModelBase
    {
        public YoutubeViewersDetailsFormViewModel YoutubeViewersDetailsFormViewModel { get; set; }

        public AddYoutubeViewerViewViewModel(ModalNavigationStore modalNavigationStore)
        {
            ICommand cancelCommand = new CloseModalCommand(modalNavigationStore);
            YoutubeViewersDetailsFormViewModel = new YoutubeViewersDetailsFormViewModel(null, cancelCommand);
        }


    }
}
