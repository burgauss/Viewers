using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viewers.Models;

namespace Viewers.Stores
{
    public class YoutubeViewerStore
    {
        public event Action<YoutubeViewer> YoutubeViewerAdded;

        public async Task Add(YoutubeViewer youtubeViewer)
        {
            YoutubeViewerAdded?.Invoke(youtubeViewer);
        }
    }
}
