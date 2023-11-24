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

        public App()
        {
            _selectedYoutubeViewersStore = new SelectedYoutubeViewersStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new ViewersViewModel(_selectedYoutubeViewersStore)
            };

            MainWindow.Show();

            base.OnStartup(e);
        }

    }
}
