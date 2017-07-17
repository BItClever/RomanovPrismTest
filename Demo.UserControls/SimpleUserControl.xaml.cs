using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Security;
using System.Windows.Input;

namespace Demo.UserControls
{
    /// <summary>
    /// Логика взаимодействия для SimpleUserControl.xaml
    /// </summary>
    public partial class SimpleUserControl : UserControl
    {
        public string SimpleText
        {
            get
            {
                return (string)GetValue(SimpleTextProperty);
            }
            set
            {
                SetValue(SimpleTextProperty, value);
            }
        }
        public List<string> SimpleChoiceList
        {
            get
            {
                return (List<string>)GetValue(SimpleChoiceListProperty);
            }
            set
            {
                SetValue(SimpleChoiceListProperty, value);
            }
        }

        public ICommand SimpleDoSomething
        {
            get
            {
                return (ICommand)GetValue(SimpleDoSomethingProperty);
            }
            set
            {
                SetValue(SimpleDoSomethingProperty, value);
            }
        }

        public static DependencyProperty SimpleTextProperty =
            DependencyProperty.Register("SimpleText", typeof(string), typeof(SimpleUserControl));

        public static DependencyProperty SimpleChoiceListProperty =
            DependencyProperty.Register("SimpleChoiceList", typeof(List<string>), typeof(SimpleUserControl));

        public static DependencyProperty SimpleDoSomethingProperty =
            DependencyProperty.Register("SimpleDoSomething", typeof(ICommand), typeof(SimpleUserControl));
        

        public SimpleUserControl()
        {
            InitializeComponent();
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
