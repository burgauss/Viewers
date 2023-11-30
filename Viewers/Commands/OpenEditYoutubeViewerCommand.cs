using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viewers.Models;
using Viewers.Stores;
using Viewers.ViewModels;

namespace Viewers.Commands
{
    public class OpenEditYoutubeViewerCommand : CommandBase
    {
        private YoutubeViewer _youtubeViewer;
        private readonly ModalNavigationStore _modalNavigationStore;

        public OpenEditYoutubeViewerCommand(YoutubeViewer youtubeViewer, ModalNavigationStore modalNavigationStore)
        {
            _youtubeViewer = youtubeViewer;
            _modalNavigationStore = modalNavigationStore;
        }

        public override void Execute(object? parameter)
        {
            EditYoutubeViewerViewModel editYoutubeViewerViewViewModel = new EditYoutubeViewerViewModel(_youtubeViewer,_modalNavigationStore);
            _modalNavigationStore.CurrentViewModel = editYoutubeViewerViewViewModel;
        }
    }
}
