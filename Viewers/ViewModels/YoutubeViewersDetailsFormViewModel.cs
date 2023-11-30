using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Viewers.ViewModels
{
    public class YoutubeViewersDetailsFormViewModel : ViewModelBase
    {
		private string _userName;
		public string Username
		{
			get
			{
				return _userName;
			}
			set
			{
				_userName = value;
				OnPropertyChanged(nameof(Username));
				OnPropertyChanged(nameof(CanSubmit));
			}
		}

		private bool _isSubscribed;
		public bool IsSubscribed
		{
			get
			{
				return _isSubscribed;
			}
			set
			{
				_isSubscribed = value;
				OnPropertyChanged(nameof(IsSubscribed));
			}
		}

		private bool _isMember;


        public bool IsMember
		{
			get
			{
				return _isMember;
			}
			set
			{
				_isMember = value;
				OnPropertyChanged(nameof(IsMember));
			}
		}

		public bool CanSubmit => !string.IsNullOrEmpty(Username);
        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }
        public YoutubeViewersDetailsFormViewModel(ICommand submitCommand, ICommand cancelCommand)
        {
            SubmitCommand = submitCommand;
            CancelCommand = cancelCommand;
        }
    }
}
