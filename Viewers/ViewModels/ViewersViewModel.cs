using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Viewers.Stores;

namespace Viewers.ViewModels
{
    class ViewersViewModel : ViewModelBase
    {
        public YoutubeViewersDetailViewModel YoutubeViewersDetailViewModel { get; }
        public YoutubeViewersListingViewModel YoutubeViewersListingViewModel { get; }
        public ICommand AddYoutubeViewerCommand { get; }

        public ViewersViewModel(SelectedYoutubeViewersStore _selectedYoutubeViewersStore)
        {
            YoutubeViewersListingViewModel = new YoutubeViewersListingViewModel(_selectedYoutubeViewersStore);

            YoutubeViewersDetailViewModel = new YoutubeViewersDetailViewModel(_selectedYoutubeViewersStore);
        }
    }
}
