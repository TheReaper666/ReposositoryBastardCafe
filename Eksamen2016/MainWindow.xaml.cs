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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public UcMenu ucMenu = null;
        public UcOverviewRes ucOverviewRes = null;
        public UcOverviewKunder ucOverviewKunder = null;
        public UcOverviewSpil ucOverviewSpil = null;

        public MainWindow()
        {
            InitializeComponent();
            ucMenu = new UcMenu(ucCenter, ucRight);
            this.ucLeft.Content = ucMenu;
        }


        private void MainForm_Closed(object sender, EventArgs e)
        {
            for (int intCounter = App.Current.Windows.Count - 1; intCounter >= 0; intCounter--) App.Current.Windows[intCounter].Close();
        }
    }
}
