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
        private readonly YoutubeViewerStore _youtubeViewerStore;
        private readonly SelectedYoutubeViewersStore _selectedYoutubeViewersStore;
        private ModalNavigationStore _modalNavigationStore;
        private readonly ModalNavigationStore modalNavigationStore;

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
        public YoutubeViewersListingViewModel(YoutubeViewerStore youtubeViewerStore, 
            SelectedYoutubeViewersStore selectedYoutubeViewersStore, 
            ModalNavigationStore modalNavigationStore)
        {
            _youtubeViewerStore = youtubeViewerStore;
            _selectedYoutubeViewersStore = selectedYoutubeViewersStore;
            _modalNavigationStore = modalNavigationStore;
            _youtubeViewersListingItemViewModel = new ObservableCollection<YoutubeViewersListingItemViewModel>();

            _youtubeViewerStore.YoutubeViewerAdded += YoutubeViewerStore_YoutubeViewerAdded;

            //AddYoutubeViewer(new YoutubeViewer("Juan Antonio", false, false), modalNavigationStore);
            //AddYoutubeViewer(new YoutubeViewer("Eneida Paola", true, true), modalNavigationStore);
            //AddYoutubeViewer(new YoutubeViewer("Davido", true, true), modalNavigationStore);
        }

        protected override void Dispose()
        {
            _youtubeViewerStore.YoutubeViewerAdded -= YoutubeViewerStore_YoutubeViewerAdded;
            base.Dispose();
        }
        private void YoutubeViewerStore_YoutubeViewerAdded(YoutubeViewer youtubeViewer)
        {
            AddYoutubeViewer(youtubeViewer);
        }

        private void AddYoutubeViewer(YoutubeViewer youtubeViewer)
        {
            ICommand editCommand = new OpenEditYoutubeViewerCommand(youtubeViewer, _modalNavigationStore);
            _youtubeViewersListingItemViewModel.Add(new YoutubeViewersListingItemViewModel(youtubeViewer, editCommand));
        }

    }
}
