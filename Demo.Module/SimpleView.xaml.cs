using System.ComponentModel.Composition;

namespace Demo.Module
{
    [Export("SimpleView")]
    [PartCreationPolicy(CreationPolicy.Shared)]
    public partial class SimpleView
    {
       // public string SimpleName { get; set; } = "123";

        [ImportingConstructor]
        public SimpleView(SimpleViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
