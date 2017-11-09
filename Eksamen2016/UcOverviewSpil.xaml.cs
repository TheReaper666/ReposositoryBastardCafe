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
using BastardCafe.Appbizz;

namespace Eksamen2016
{
    /// <summary>
    /// Interaction logic for UcOverviewSpil.xaml
    /// </summary>
    public partial class UcOverviewSpil : UserControl
    {
        public BastardCafeBizz Bizz;
        private UserControl ucRight;
        public UcOverviewSpil(object ucr, BastardCafeBizz bizz)
        {
            Bizz = bizz;
            InitializeComponent();
            //dataGridSpil.ItemsSource = bizz.DataSpil;
            ucRight = (UserControl)ucr;

        }

        private void TextBoxSøgeFeltSpil_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void DataGridSpil_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UcDetailsSpilOpret UCS = new UcDetailsSpilOpret(false, Bizz);
        }

        private void BtnOpretSpil_Click(object sender, RoutedEventArgs e)
        {
            UcDetailsSpilOpret UCS = new UcDetailsSpilOpret(true, Bizz);
        }
    }
}
