using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Viewers.Commands;
using Viewers.Models;
using Viewers.Stores;

namespace Viewers.ViewModels
{
    public class EditYoutubeViewerViewModel : ViewModelBase
    {
        public YoutubeViewersDetailsFormViewModel YoutubeViewersDetailsFormViewModel { get; set; }

        public EditYoutubeViewerViewModel(YoutubeViewer youtubeViewer, ModalNavigationStore modalNavigationStore)
        {
            ICommand cancelCommand = new CloseModalCommand(modalNavigationStore);
            YoutubeViewersDetailsFormViewModel = new YoutubeViewersDetailsFormViewModel(null, cancelCommand)
            {
                Username = youtubeViewer.Username,
                IsMember = youtubeViewer.IsMember,
                IsSubscribed = youtubeViewer.IsSubscribed
            };
        }
    }
}
