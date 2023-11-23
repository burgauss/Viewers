using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Viewers.ViewModels
{
    class ViewersViewModel : ViewModelBase
    {
        public YoutubeViewersDetailViewModel YoutubeViewersDetailViewModel { get; }
        public YoutubeViewersListingViewModel YoutubeViewersListingViewModel { get; }
        public ICommand AddYoutubeViewerCommand { get; }

        public ViewersViewModel()
        {
            YoutubeViewersListingViewModel = new YoutubeViewersListingViewModel();

            YoutubeViewersDetailViewModel = new YoutubeViewersDetailViewModel();
        }
    }
}
