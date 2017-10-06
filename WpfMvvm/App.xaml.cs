using System.Windows;
using WpfMvvm.InversionOfControl;
using WpfMvvm.Configurations;

namespace WpfMvvm
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            Configuration.Resolver = new UnityDependencyResolver(ContainerFactory.CreateUnityContainer());
            Configuration.Resolver.RegisterTypes();

            var mainWindowView = new MainWindow.MainWindowView();
            mainWindowView.Show();
        }
    }
}
