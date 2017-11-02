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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Eksamen2016
{
    /// <summary>
    /// Interaction logic for UcOverWievRes.xaml
    /// </summary>
    public partial class UcOverviewRes : UserControl
    {
        private UserControl ucRight;
        public UcOverviewRes(object ucr)
        {
            InitializeComponent();
            ucRight = (UserControl)ucr;
        }

        private void BtnOpretRes_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DataGridOVR_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextboxSøgefelt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
