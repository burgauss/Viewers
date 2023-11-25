using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viewers.Models;
using Viewers.Stores;

namespace Viewers.ViewModels
{
    public class YoutubeViewersListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<YoutubeViewersListingItemViewModel> _youtubeViewersListingItemViewModel;
        private readonly SelectedYoutubeViewersStore _selectedYoutubeViewersStore;

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

                _selectedYoutubeViewersStore.SelectedYoutubeViewer = _selectedYoutubeViewerListingItemViewModel?.YoutubeViewer;
            }
        }
        public YoutubeViewersListingViewModel(SelectedYoutubeViewersStore selectedYoutubeViewersStore)
        {
            _selectedYoutubeViewersStore = selectedYoutubeViewersStore;
            _youtubeViewersListingItemViewModel = new ObservableCollection<YoutubeViewersListingItemViewModel>();

            _youtubeViewersListingItemViewModel.Add(new YoutubeViewersListingItemViewModel(new YoutubeViewer("Juan Antonio", false, false)));
            _youtubeViewersListingItemViewModel.Add(new YoutubeViewersListingItemViewModel(new YoutubeViewer("Eneida Paola", true, true)));
            _youtubeViewersListingItemViewModel.Add(new YoutubeViewersListingItemViewModel(new YoutubeViewer("Davido", true, true)));
        }

    }
}
