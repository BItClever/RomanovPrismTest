using Prism.Mef.Modularity;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.ComponentModel.Composition;
using Prism.Logging;

namespace Demo.Module
{
    [ModuleExport(typeof(DemoModule))]
    public class DemoModule : IModule
    {
        [Import]
        public IRegionManager RegionManager;

        ILoggerFacade _logger;

        [ImportingConstructor]
        public DemoModule(ILoggerFacade logger, IRegionManager regionManager)
        {
            _logger = logger;
        }

        public void Initialize()
        {
            _logger.Log("Demo.Module loaded", Category.Info, Priority.Medium);
            Uri simpleViewNav = new Uri("SimpleView", UriKind.Relative);
            RegionManager.RequestNavigate("DemoRegion", simpleViewNav);
        }
    }
}
