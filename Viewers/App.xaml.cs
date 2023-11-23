using System.Windows;
using Viewers.ViewModels;

namespace Viewers
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new ViewersViewModel()
            };

            MainWindow.Show();

            base.OnStartup(e);
        }

    }
}
