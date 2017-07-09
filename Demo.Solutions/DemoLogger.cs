using Prism.Logging;
using log4net;
using System.ComponentModel.Composition;
using log4net.Config;

namespace Demo.Solutions
{
    [Export(typeof(ILoggerFacade))]
    public class DemoLogger : ILoggerFacade
    {
        private readonly ILog myDemoLogger = LogManager.GetLogger(typeof(DemoLogger));

        public void Log(string message, Category category, Priority priority)
        {
            switch (category)
            {
                case Category.Debug:
                    myDemoLogger.Debug(message);
                    break;
                case Category.Warn:
                    myDemoLogger.Warn(message);
                    break;
                case Category.Exception:
                    myDemoLogger.Error(message);
                    break;
                case Category.Info:
                    myDemoLogger.Info(message);
                    break;
            }
        }


        public DemoLogger() : base()
        {
            XmlConfigurator.Configure();
           // myDemoLogger.Info("This is just to inform you");
        }
    }
}
