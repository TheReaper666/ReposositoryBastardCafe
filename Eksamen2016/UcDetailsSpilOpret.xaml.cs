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
using BastardCafe.BizzEntities;

namespace Eksamen2016
{
    /// <summary>
    /// Interaction logic for UcDetailsSpilOpret.xaml
    /// </summary>
    public partial class UcDetailsSpilOpret : UserControl
    {
        bool boolspilOpret;
        BastardCafeBizz Bizz;
        public UcDetailsSpilOpret(bool boolSpilopret, BastardCafeBizz bizz)
        {
            InitializeComponent();
            boolspilOpret = boolSpilopret;
            Bizz = bizz;
            if (boolSpilopret == true)
            {
                btnOpret.Content = "Opret";
            }
            else
            {
                btnOpret.Content = "Opdater";
            }
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            radioBtnAktiv.IsChecked = true;
        }

        private void TextBoxSpilNavn_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnOpret_Click(object sender, RoutedEventArgs e)
        {
            if (boolspilOpret == true)
            {
                string spilNavn = textBoxSpilNavn.Text;
                string spilGenre = comboBoxGenre.SelectedItem.ToString();
                string spilDeltagere = comboBoxDeltager.SelectedItem.ToString();
                string spilBeskivelse = textBoxBeskrivelse.Text;
                int SpilleTid = (int)comboBoxNormalTid.SelectedItem;
                radioBtnInaktiv.IsEnabled = false;
                bool spilActiveret = true;
                Bizz.CreateSpilData(spilNavn, spilGenre, spilDeltagere, spilBeskivelse, SpilleTid, spilActiveret);
                
                // Funktion til at Oprette
            }
            else
            {
                // Funktion til at Opdatere
            }
        }
    }
}
