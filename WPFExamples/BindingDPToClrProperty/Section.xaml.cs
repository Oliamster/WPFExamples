using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BindingDPToClrProperty
{
    /// <summary>
    /// Interaction logic for CostumUserControl.xaml
    /// </summary>
    public partial class Section : UserControl
    {
        public Section()
        {
            InitializeComponent();
            DataContext = this;
        }

        public string SectionFontSize { get; set; }
        public string SectionTitle { get; set; }
    }
}
