using Prism.Regions;
using System.ComponentModel.Composition;

namespace Demo.Module
{
    [Export]
    public class SimpleViewModel : INavigationAware
    {
        [Import]
        public IRegionManager RegionManager;

        void INavigationAware.OnNavigatedTo(NavigationContext navigationContext)
        {
            NavigationParameters parameters = navigationContext.Parameters;
           // RegionManager.RequestNavigate("DemoRegion", new Uri("SimpleView", UriKind.Relative));
        }

        bool INavigationAware.IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        void INavigationAware.OnNavigatedFrom(NavigationContext navigationContext)
        {

        }
    }
}
