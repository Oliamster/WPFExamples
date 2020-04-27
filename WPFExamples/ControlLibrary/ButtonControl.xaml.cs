using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ControlLibrary
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class ButtonControl : UserControl
    {
        public ButtonControl()
        {
            InitializeComponent();
        }

        public ICommand ControlCommand
        {
            get { return (ICommand)GetValue(ControlCommandProperty); }
            set { SetValue(ControlCommandProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ControlCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ControlCommandProperty =
            DependencyProperty.Register("ControlCommand", typeof(ICommand), typeof(ButtonControl), new PropertyMetadata(null));
    }
}