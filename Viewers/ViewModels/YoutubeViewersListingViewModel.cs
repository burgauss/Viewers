using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Viewers.Commands;
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
        public YoutubeViewersListingViewModel(SelectedYoutubeViewersStore selectedYoutubeViewersStore, ModalNavigationStore modalNavigationStore)
        {
            _selectedYoutubeViewersStore = selectedYoutubeViewersStore;
            _youtubeViewersListingItemViewModel = new ObservableCollection<YoutubeViewersListingItemViewModel>();

            AddYoutubeViewer(new YoutubeViewer("Juan Antonio", false, false), modalNavigationStore);
            AddYoutubeViewer(new YoutubeViewer("Eneida Paola", true, true), modalNavigationStore);
            AddYoutubeViewer(new YoutubeViewer("Davido", true, true), modalNavigationStore);
        }

        private void AddYoutubeViewer(YoutubeViewer youtubeViewer, ModalNavigationStore modalNavigationStore)
        {
            ICommand editCommand = new OpenEditYoutubeViewerCommand(youtubeViewer, modalNavigationStore);
            _youtubeViewersListingItemViewModel.Add(new YoutubeViewersListingItemViewModel(youtubeViewer, editCommand));
        }

    }
}
