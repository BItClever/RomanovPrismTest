using Demo.Solutions;
using Prism.Logging;
using Prism.Mef;
using Prism.Modularity;
using System;
using System.ComponentModel.Composition.Hosting;
using System.Windows;

namespace DemoApplication
{
    public class DemoBootstrapper : MefBootstrapper
    {

        private readonly DemoLogger _logger = new DemoLogger();

        protected override DependencyObject CreateShell()
        {
            return this.Container.GetExportedValue<ShellView>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureAggregateCatalog()
        {
            base.ConfigureAggregateCatalog();
            AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(DemoBootstrapper).Assembly));
            AggregateCatalog.Catalogs.Add(new DirectoryCatalog(AppDomain.CurrentDomain.BaseDirectory, "Demo.*.dll"));
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            return new ConfigurationModuleCatalog();
        }


    }
}
