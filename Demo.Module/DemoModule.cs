using Prism.Mef.Modularity;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.ComponentModel.Composition;
using Prism.Logging;
using Demo.Solutions;

namespace Demo.Module
{
    [ModuleExport(typeof(DemoModule))]
    public class DemoModule : IModule
    {
        [Import]
        public IRegionManager RegionManager;

        private readonly DemoLogger _logger = new DemoLogger();

        public void Initialize()
        {
            _logger.Log("Demo.Module loaded", Category.Info, Priority.Medium);
            Uri simpleViewNav = new Uri("SimpleView", UriKind.Relative);
            RegionManager.RequestNavigate("DemoRegion", simpleViewNav);
        }
    }
}
