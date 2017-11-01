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
        private UserControl ucCenter;
        private UserControl ucRight;
        private UcOverviewRes ucOverviewRes;
        private UcOverviewKunder ucOverviewKunder;
        private UcOverviewSpil ucOverviewSpil;

        public UcMenu(object ucc, object ucr)
        {
            InitializeComponent();
            ucCenter = (UserControl)ucc;
            ucRight = (UserControl)ucr;
            ucOverviewRes = new UcOverviewRes(ucr);
            ucOverviewKunder = new UcOverviewKunder(ucr);
            ucOverviewSpil = new UcOverviewSpil(ucr);
        }

        private void BtnReservationer_Click(object sender, RoutedEventArgs e)
        {
            ucCenter.Content = ucOverviewRes;
        }

        private void BtnKunder_Click(object sender, RoutedEventArgs e)
        {
            ucCenter.Content = ucOverviewKunder;
        }

        private void BtnSpil_Click(object sender, RoutedEventArgs e)
        {
            ucCenter.Content = ucOverviewSpil;
        }
    }
}
