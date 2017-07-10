using Prism.Mef.Modularity;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.ComponentModel.Composition;
using Prism.Logging;
using System.Collections.Generic;

namespace Demo.Module
{
    [ModuleExport(typeof(DemoModule))]
    public class DemoModule : IModule
    {
        private readonly IEnumerable<ILoggerFacade> _loggers;
        private readonly IRegionManager _regionManager;

        [ImportingConstructor]
        public DemoModule([ImportMany] IEnumerable<ILoggerFacade> loggers, IRegionManager regionManager)
        {
            _loggers = loggers;
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            Log("Demo.Module loaded");
            Uri simpleViewNav = new Uri("SimpleView", UriKind.Relative);
            _regionManager.RequestNavigate("DemoRegion", simpleViewNav);
        }

        private void Log(string message)
        {
            foreach (var logger in _loggers)
            {
                logger.Log(message, Category.Info, Priority.None);
            }
        }
    }
}