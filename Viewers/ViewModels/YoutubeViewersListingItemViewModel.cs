using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Viewers.ViewModels
{
    public class YoutubeViewersListingItemViewModel : ViewModelBase
    {
        public string Username { get; }
        public ICommand Edit { get; }
        public ICommand Delete { get; }

        public YoutubeViewersListingItemViewModel(string username)
        {
            Username = username;

        }
    }
}
