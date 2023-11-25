using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viewers.Models;
using Viewers.Stores;

namespace Viewers.ViewModels
{

    public class YoutubeViewersDetailViewModel : ViewModelBase
    {
        private readonly SelectedYoutubeViewersStore _selectedYoutubeViewersStore;

        private YoutubeViewer SelectedYoutubeViewer => _selectedYoutubeViewersStore.SelectedYoutubeViewer;
        public bool HasSelectedYoutubeViewer => SelectedYoutubeViewer != null;        //maybe to control the display of details only when the selection occurs
        public string Username => SelectedYoutubeViewer?.Username ?? "Unknow";

        private bool _isSubscribedDisplay;
        public bool IsSubscribedDisplay
        {
            get => SelectedYoutubeViewer?.IsSubscribed ?? false;
            set => _isSubscribedDisplay = value;
        }

        public bool _isMemberDisplay;
        public bool IsMemberDisplay
        {
            get => SelectedYoutubeViewer?.IsMember ?? false;
            set => _isMemberDisplay = value;
        }

        public YoutubeViewersDetailViewModel(SelectedYoutubeViewersStore selectedYoutubeViewersStore)
        {
            _selectedYoutubeViewersStore = selectedYoutubeViewersStore;

            _selectedYoutubeViewersStore.SelectedYoutubeViewerChanged += _selectedYoutubeViewersStore_SelectedYoutubeViewerChanged;
        }


        protected override void Dispose()
        {
            _selectedYoutubeViewersStore.SelectedYoutubeViewerChanged -= _selectedYoutubeViewersStore_SelectedYoutubeViewerChanged;
            base.Dispose();
        }
        private void _selectedYoutubeViewersStore_SelectedYoutubeViewerChanged()
        {
            OnPropertyChanged(nameof(HasSelectedYoutubeViewer));
            OnPropertyChanged(nameof(Username));
            OnPropertyChanged(nameof(IsSubscribedDisplay));
            OnPropertyChanged(nameof(IsMemberDisplay));
        }


    }
}
