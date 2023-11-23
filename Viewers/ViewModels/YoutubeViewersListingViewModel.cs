using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viewers.ViewModels
{
    public class YoutubeViewersListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<YoutubeViewersListingItemViewModel> _youtubeViewersListingItemViewModel;
        public IEnumerable<YoutubeViewersListingItemViewModel> youtubeViewersListingItemViewModels => _youtubeViewersListingItemViewModel;

        public YoutubeViewersListingViewModel()
        {
            _youtubeViewersListingItemViewModel = new ObservableCollection<YoutubeViewersListingItemViewModel>();
            _youtubeViewersListingItemViewModel.Add(new YoutubeViewersListingItemViewModel("Juan"));
            _youtubeViewersListingItemViewModel.Add(new YoutubeViewersListingItemViewModel("Eneida Paola"));
            _youtubeViewersListingItemViewModel.Add(new YoutubeViewersListingItemViewModel("David"));


        }

    }
}
