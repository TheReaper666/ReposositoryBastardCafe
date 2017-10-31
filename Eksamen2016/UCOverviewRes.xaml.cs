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
    /// Interaction logic for UCOverviewRes.xaml
    /// </summary>
    public partial class UCOverviewRes : UserControl
    {
        public Window callWindow;
        public UCOverviewRes(object from)
        {
            InitializeComponent();
            callWindow = (Window)from;

        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            callWindow.Show();
        }

        private void textBoxSoeg_TextChanged(object sender, TextChangedEventArgs e)
        {
            groupBoxTodayReservation.Header = "Resultat af søgning";
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            textBoxSoeg.Text = "";
            groupBoxTodayReservation.Header = "Reservationer knyttet til dagen";
            //labelResShowDato.Content = DatePickerResDato.SelectedDate.ToString();
        }
    }
}
