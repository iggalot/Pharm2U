using Pharm2U.IoC;
using System.Windows;

namespace Pharm2U
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        // The main application window
        public MainWindow MainAppWindow;

        /// <summary>
        /// Override the OnStartup functionality so that we can setup Ninject for dependency inject
        /// </summary>
        /// <param name="e"></param>
        protected override void OnStartup(StartupEventArgs e)
        {
            // Allow the base system to startup as normal
            base.OnStartup(e);

            // Setup our dependency injection for Inversion of Control (IoC)
            IoCContainer.Setup();

            // Now create our main application window
            MainAppWindow = new MainWindow();
            Current.MainWindow = MainAppWindow;
            Current.MainWindow.Show();
        }
    }
}
