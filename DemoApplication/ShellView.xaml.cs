using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Prism.Logging;
using Prism.Modularity;
using System.ComponentModel.Composition;

namespace DemoApplication
{
    /// <summary>
    /// Логика взаимодействия для ShellView.xaml
    /// </summary>
   [Export]
    public partial class ShellView : Window
    {
        public ShellView()
        {
            InitializeComponent();
        }
    }
}
