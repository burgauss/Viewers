using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viewers.Stores;

namespace Viewers.Commands
{
    public class EditYoutubeViewerCommand : AsyncCommandBase
    {
        private readonly ModalNavigationStore _modalNavigationStore;

        public EditYoutubeViewerCommand(ModalNavigationStore modalNavigationStore)
        {
            _modalNavigationStore = modalNavigationStore;
        }
        public override async Task ExecuteAsync(object parameter)
        {
            //Add youtube viewer to database
            _modalNavigationStore.Close();
        }
    }
}
