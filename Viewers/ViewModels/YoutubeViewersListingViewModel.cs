using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viewers.Stores;

namespace Viewers.ViewModels
{
    public class YoutubeViewersListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<YoutubeViewersListingItemViewModel> _youtubeViewersListingItemViewModel;
        private readonly SelectedYoutubeViewersStore selectedYoutubeViewersStore;

        public IEnumerable<YoutubeViewersListingItemViewModel> youtubeViewersListingItemViewModels => _youtubeViewersListingItemViewModel;

        public YoutubeViewersListingItemViewModel _selectedYoutubeViewerListingItemViewModel;
        public YoutubeViewersListingItemViewModel SelectedYoutubeViewerListingItemViewModel
        {
            get
            {
                return _selectedYoutubeViewerListingItemViewModel;
            }
            set
            {
                _selectedYoutubeViewerListingItemViewModel = value;
                OnPropertyChanged(nameof(SelectedYoutubeViewerListingItemViewModel));

                selectedYoutubeViewersStore.SelectedYoutubeViewer = new Models.YoutubeViewer();
            }
        }
        public YoutubeViewersListingViewModel(SelectedYoutubeViewersStore _selectedYoutubeViewersStore)
        {
            _youtubeViewersListingItemViewModel = new ObservableCollection<YoutubeViewersListingItemViewModel>();
            _youtubeViewersListingItemViewModel.Add(new YoutubeViewersListingItemViewModel("Juan"));
            _youtubeViewersListingItemViewModel.Add(new YoutubeViewersListingItemViewModel("Eneida Paola"));
            _youtubeViewersListingItemViewModel.Add(new YoutubeViewersListingItemViewModel("David"));
            selectedYoutubeViewersStore = _selectedYoutubeViewersStore;
        }

    }
}
