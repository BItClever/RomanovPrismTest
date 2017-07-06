using System.ComponentModel.Composition;

namespace DemoApplication
{
    /// <summary>
    /// Логика взаимодействия для ShellView.xaml
    /// </summary>
    [Export]
    public partial class ShellView
    {
        public ShellView()
        {
            InitializeComponent();
        }
    }
}