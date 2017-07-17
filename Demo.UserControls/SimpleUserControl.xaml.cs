using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

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

        public static DependencyProperty SimpleTextProperty =
            DependencyProperty.Register("SimpleText", typeof(string), typeof(SimpleUserControl));

        public static DependencyProperty SimpleChoiceListProperty =
            DependencyProperty.Register("SimpleChoiceList", typeof(List<string>), typeof(SimpleUserControl));

        
        public SimpleUserControl()
        {
            InitializeComponent();
        }

      
    }
}
