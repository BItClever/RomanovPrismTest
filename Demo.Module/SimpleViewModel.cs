using Prism.Regions;
using System.ComponentModel.Composition;
using Demo.UserControls;
using System.ComponentModel;
using System.Collections.Generic;

namespace Demo.Module
{
    [Export]
    public class SimpleViewModel : INavigationAware
    {
        [Import]
        public IRegionManager RegionManager;


        public string SimpleText { get; set; } = "simple string";
        public List<string> SimpleChoiceList { get; set; } = new List<string> { "aaa", "bbb", "ccc" };

                        
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
