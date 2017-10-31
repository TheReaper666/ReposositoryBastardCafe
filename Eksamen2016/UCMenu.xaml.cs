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
    /// Interaction logic for UCMenu.xaml
    /// </summary>
    public partial class UCMenu : UserControl
    {
        public UserControl uCCenter;
        public UCOverviewRes ucOverviewRes;

        public UCMenu(object ucr)
        {
            InitializeComponent();
            uCCenter = (UserControl)ucr;
            ucOverviewRes = new UCOverviewRes(this);
        }

        private void ButtonReservations_Click(object sender, RoutedEventArgs e)
        {
            uCCenter.Content = ucOverviewRes;
        }

        private void ButtonCustomers_Click(object sender, RoutedEventArgs e)
        {
            uCCenter.Content = ucOverviewRes;
        }

        private void ButtonGames_Click(object sender, RoutedEventArgs e)
        {
            uCCenter.Content = ucOverviewRes;
        }
    }
}
