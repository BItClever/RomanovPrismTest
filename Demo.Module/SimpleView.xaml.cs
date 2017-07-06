using System.ComponentModel.Composition;

namespace Demo.Module
{
    [Export("SimpleView")]
    [PartCreationPolicy(CreationPolicy.Shared)]
    public partial class SimpleView
    {
        [ImportingConstructor]
        public SimpleView(SimpleViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
