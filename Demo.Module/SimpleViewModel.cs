using Prism.Regions;
using System.ComponentModel.Composition;
using Demo.UserControls;
using System.ComponentModel;
using System.Collections.Generic;
using Prism.Mvvm;
using System.Windows.Input;
using Prism.Commands;

namespace Demo.Module
{
    [Export]
    public class SimpleViewModel : BindableBase, INavigationAware
    {

        public SimpleViewModel()
        {
            SimpleDoSomethingCommand = new DelegateCommand(simpleDoSomething);
        }

        [Import]
        public IRegionManager RegionManager;

        private string _simpleText = "simple string";
        private List<string> _simpleChoiceList = new List<string> { "aaa", "bbb", "ccc" };

        public string SimpleText
        {
            get { return _simpleText; }
            set { SetProperty(ref _simpleText, value); }
        }

        public List<string> SimpleChoiceList
        {
            get { return _simpleChoiceList; }
            set { SetProperty(ref _simpleChoiceList, value); }
        }

        public ICommand SimpleDoSomethingCommand { get; set; }

        private void simpleDoSomething()
        {
            SimpleText = "Button pressed";
        }

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
