using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viewers.ViewModels
{
    public class EditYoutubeViewerViewModel : ViewModelBase
    {
        public YoutubeViewersDetailsFormViewModel YoutubeViewersDetailsFormViewModel { get; set; }

        public EditYoutubeViewerViewModel()
        {
            YoutubeViewersDetailsFormViewModel = new YoutubeViewersDetailsFormViewModel();
        }
    }
}
