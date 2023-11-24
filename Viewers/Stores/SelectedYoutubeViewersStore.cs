using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viewers.Models;

namespace Viewers.Stores
{
    public class SelectedYoutubeViewersStore
    {
        private YoutubeViewer _selectedYoutubeViewer;
        public YoutubeViewer SelectedYoutubeViewer
        {
            get
            {
                return _selectedYoutubeViewer;
            }
            private set
            {
                _selectedYoutubeViewer = value;
                SelectedYoutubeViewerChanged?.Invoke();
            }
        }

        public event Action SelectedYoutubeViewerChanged;
    }
}
