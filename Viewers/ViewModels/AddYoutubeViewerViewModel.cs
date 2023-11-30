using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viewers.ViewModels
{
    public class AddYoutubeViewerViewViewModel  :ViewModelBase
    {
        public YoutubeViewersDetailsFormViewModel YoutubeViewersDetailsFormViewModel { get; set; }

        public AddYoutubeViewerViewViewModel()
        {
            YoutubeViewersDetailsFormViewModel = new YoutubeViewersDetailsFormViewModel();
        }


    }
}
