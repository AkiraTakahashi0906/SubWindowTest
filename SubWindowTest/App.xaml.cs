using SubWindowTest.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;
using SubWindowTest.ViewModels;
using Prism.Regions;

namespace SubWindowTest
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            var subwindow = new PrismSubWindow();
            subwindow.Show();
            RegionManager.SetRegionManager(subwindow, Container.Resolve<IRegionManager>());
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
