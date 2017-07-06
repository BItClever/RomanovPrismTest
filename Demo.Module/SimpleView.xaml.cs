using Prism.Mef.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Demo.Module
{

    [Export("SimpleView")]
    [PartCreationPolicy(CreationPolicy.Shared)]
    public partial class SimpleView : UserControl, INavigationAware
    {
        [Import]
        public IRegionManager RegionManager;

        public SimpleView()
        {
            InitializeComponent();
        }

        void INavigationAware.OnNavigatedTo(NavigationContext navigationContext)
        {
            RegionManager.RequestNavigate("DemoRegion", new Uri("SimpleView", UriKind.Relative));
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
