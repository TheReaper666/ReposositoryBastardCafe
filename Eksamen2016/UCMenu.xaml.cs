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
    /// Interaction logic for UcMenu.xaml
    /// </summary>
    public partial class UcMenu : UserControl
    {
        public UserControl ucCenter;
        public UcOverviewRes ucOverviewRes;

        public UcMenu(object ucr)
        {
            InitializeComponent();
            ucCenter = (UserControl)ucr;
            ucOverviewRes = new UcOverviewRes(this);
        }

        private void ButtonReservations_Click(object sender, RoutedEventArgs e)
        {
            ucCenter.Content = ucOverviewRes;
        }

        private void ButtonCustomers_Click(object sender, RoutedEventArgs e)
        {
            ucCenter.Content = ucOverviewRes;
        }

        private void ButtonGames_Click(object sender, RoutedEventArgs e)
        {
            ucCenter.Content = ucOverviewRes;
        }
    }
}
