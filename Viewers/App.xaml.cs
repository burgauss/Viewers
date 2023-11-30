using System.Windows;
using Viewers.Stores;
using Viewers.ViewModels;

namespace Viewers
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly SelectedYoutubeViewersStore _selectedYoutubeViewersStore;
        private readonly ModalNavigationStore _modalNavigationStore;

        public App()
        {
            _modalNavigationStore = new ModalNavigationStore();
            _selectedYoutubeViewersStore = new SelectedYoutubeViewersStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            ViewersViewModel youtubeViewersViewModel = new ViewersViewModel(_selectedYoutubeViewersStore);
                
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_modalNavigationStore, youtubeViewersViewModel)
            };

            MainWindow.Show();

            base.OnStartup(e);
        }

    }
}
