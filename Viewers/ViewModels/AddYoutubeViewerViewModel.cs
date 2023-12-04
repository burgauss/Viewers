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

        public AddYoutubeViewerViewViewModel(YoutubeViewerStore youtubeViewerStore, ModalNavigationStore modalNavigationStore)
        {
            ICommand submitCommand = new AddYoutubeViewerCommand(this, youtubeViewerStore, modalNavigationStore);
            ICommand cancelCommand = new CloseModalCommand(modalNavigationStore);
            YoutubeViewersDetailsFormViewModel = new YoutubeViewersDetailsFormViewModel(submitCommand, cancelCommand);
        }


    }
}
