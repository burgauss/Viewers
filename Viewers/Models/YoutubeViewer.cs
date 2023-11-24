using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Viewers.Models
{
    public class YoutubeViewer
    {
        public string Username { get; }
        public bool IsSubscribed { get; }
        public bool IsMember { get; }

        public YoutubeViewer(string username, bool isSubscribed, bool isMember)
        {
            Username = username;
            IsSubscribed = isSubscribed;
            IsMember = isMember;
        }
    }
}
