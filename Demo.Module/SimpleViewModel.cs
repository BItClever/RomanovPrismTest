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
    [ModuleExport(typeof(SimpleViewModel))]
    public class SimpleViewModel : INavigationAware
    {
        public string DemoString { get; set; }

        [Import]
        public IRegionManager regionManager;

        void INavigationAware.OnNavigatedTo(NavigationContext navigationContext)
        {
            // todo: 18 - Navigating an inner region based on context
            // The ContactsView will navigate an inner region based on the
            // value of the 'Show' query parameter.  If the value is 'Avatars'
            // we will navigate to the avatar view otherwise we'll use the details view.

            NavigationParameters parameters = navigationContext.Parameters;

        }

        bool INavigationAware.IsNavigationTarget(NavigationContext navigationContext)
        {
            // This view will handle all navigation view requests for ContactsView, so we always return true.
            return true;
        }

        void INavigationAware.OnNavigatedFrom(NavigationContext navigationContext)
        {
            // Intentionally not implemented
        }
    }
}
