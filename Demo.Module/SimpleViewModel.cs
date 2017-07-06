using Prism.Regions;
using Prism.Mef;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mef.Modularity;

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
