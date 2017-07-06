using Prism.Mef.Modularity;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Demo.Module
{
    [ModuleExport(typeof(DemoModule))]
    public class DemoModule : IModule
    {
        [Import]
        public IRegionManager RegionManager;

        public void Initialize()
        {
            Uri simpleViewNav = new Uri("SimpleView", UriKind.Relative);
            RegionManager.RequestNavigate("DemoRegion", simpleViewNav);
        }
    }
}
