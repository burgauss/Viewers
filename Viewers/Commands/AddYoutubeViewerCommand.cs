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
    public class AddYoutubeViewerCommand : AsyncCommandBase
    {
        private readonly AddYoutubeViewerViewViewModel _addYoutubeViewerViewViewModel;
        private readonly YoutubeViewerStore _youtubeViewerStore;
        private readonly ModalNavigationStore _modalNavigationStore;

        public AddYoutubeViewerCommand(AddYoutubeViewerViewViewModel addYoutubeViewerViewViewModel, YoutubeViewerStore youtubeViewerStore, ModalNavigationStore modalNavigationStore)
        {
            _addYoutubeViewerViewViewModel = addYoutubeViewerViewViewModel;
            _youtubeViewerStore = youtubeViewerStore;
            _modalNavigationStore = modalNavigationStore;
        }
        public override async Task ExecuteAsync(object parameter)
        {
            YoutubeViewersDetailsFormViewModel formViewModel = _addYoutubeViewerViewViewModel.YoutubeViewersDetailsFormViewModel;

            YoutubeViewer youtubeViewer = new YoutubeViewer(
                formViewModel.Username, 
                formViewModel.IsSubscribed, 
                formViewModel.IsMember);

            try
            {
                await _youtubeViewerStore.Add(youtubeViewer);

                _modalNavigationStore.Close();
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
