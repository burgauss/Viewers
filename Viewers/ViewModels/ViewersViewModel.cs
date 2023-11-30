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
    public class ViewersViewModel : ViewModelBase
    {
        public YoutubeViewersDetailViewModel YoutubeViewersDetailViewModel { get; }
        public YoutubeViewersListingViewModel YoutubeViewersListingViewModel { get; }
        public ICommand AddYoutubeViewerCommand { get; }

        public ViewersViewModel(SelectedYoutubeViewersStore _selectedYoutubeViewersStore, ModalNavigationStore modalNavigationStore)
        {
            YoutubeViewersListingViewModel = new YoutubeViewersListingViewModel(_selectedYoutubeViewersStore);

            YoutubeViewersDetailViewModel = new YoutubeViewersDetailViewModel(_selectedYoutubeViewersStore);

            AddYoutubeViewerCommand = new OpenAddYoutubeViewerCommand(modalNavigationStore);
        }
    }
}
