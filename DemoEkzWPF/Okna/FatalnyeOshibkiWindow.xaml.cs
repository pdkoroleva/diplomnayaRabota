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
using System.Windows.Shapes;

namespace DemoEkzWPF.Okna
{
    /// <summary>
    /// Логика взаимодействия для FatalnyeOshibkiWindow.xaml
    /// </summary>
    public partial class FatalnyeOshibkiWindow : Window
    {
        public FatalnyeOshibkiWindow()
        {
            InitializeComponent();
            MenuGrid.Visibility = Visibility.Collapsed;
            ZavesaGrid.Visibility = Visibility.Collapsed;
        }

        private void NazadButtonClick(object sender, RoutedEventArgs e)
        {
            PodkluchenieBDWindow podkluchenieBD = new PodkluchenieBDWindow();
            podkluchenieBD.Show();
            this.Hide();
        }

        private void VperedButtonClick(object sender, RoutedEventArgs e)
        {
            AvtorizaciaWindow avtorizacia = new AvtorizaciaWindow();
            avtorizacia.Show();
            this.Hide();
        }

        private void ZakrytMenuButtonClick(object sender, RoutedEventArgs e)
        {
            MenuGrid.Visibility = Visibility.Collapsed;
            ZavesaGrid.Visibility = Visibility.Collapsed;
        }

        private void StrukturaTextBlockMouseDown(object sender, MouseButtonEventArgs e)
        {
            StrukturaWindow struktura = new StrukturaWindow();
            struktura.Show();
            this.Hide();
        }

        private void RazmetkaTextBlockMouseDown(object sender, MouseButtonEventArgs e)
        {
            RazmetkaWindow razmetka = new RazmetkaWindow();
            razmetka.Show();
            this.Hide();
        }

        private void PodkluchenieTextBlockMouseDown(object sender, MouseButtonEventArgs e)
        {
            PodkluchenieBDWindow podkluchenieBD = new PodkluchenieBDWindow();
            podkluchenieBD.Show();
            this.Hide();
        }


        private void AvtorizaciaTextBlockMouseDown(object sender, MouseButtonEventArgs e)
        {
            AvtorizaciaWindow avtorizacia = new AvtorizaciaWindow();
            avtorizacia.Show();
            this.Hide();
        }

        private void VyvodTextBlockMouseDown(object sender, MouseButtonEventArgs e)
        {
            VyvodWindow vyvod = new VyvodWindow();
            vyvod.Show();
            this.Hide();
        }

        private void DobavlenieTextBlockMouseDown(object sender, MouseButtonEventArgs e)
        {
            DobavlenieWindow dobavlenie = new DobavlenieWindow();
            dobavlenie.Show();
            this.Hide();
        }

        private void IzmenenieTextBlockMouseDown(object sender, MouseButtonEventArgs e)
        {
            IzmenenieWindow izmenenie = new IzmenenieWindow();
            izmenenie.Show();
            this.Hide();
        }

        private void UdalenieTextBlockMouseDown(object sender, MouseButtonEventArgs e)
        {
            UdalenieWindow udalenie = new UdalenieWindow();
            udalenie.Show();
            this.Hide();
        }

        private void PoiskTextBlockMouseDown(object sender, MouseButtonEventArgs e)
        {
            PoiskWindow poisk = new PoiskWindow();
            poisk.Show();
            this.Hide();
        }

        private void ZapolnenieCBTextBlockMouseDown(object sender, MouseButtonEventArgs e)
        {
            ZapolnenieCBWindow zapolnenieCB = new ZapolnenieCBWindow();
            zapolnenieCB.Show();
            this.Hide();
        }

        private void SortirovkaTextBlockMouseDown(object sender, MouseButtonEventArgs e)
        {
            SortirovkaWindow sortirovka = new SortirovkaWindow();
            sortirovka.Show();
            this.Hide();
        }

        private void FiltraciaTextBlockMouseDown(object sender, MouseButtonEventArgs e)
        {
            FiltraciaWindow filtracia = new FiltraciaWindow();
            filtracia.Show();
            this.Hide();
        }

        private void MenuImageMouseDown(object sender, MouseButtonEventArgs e)
        {
            MenuGrid.Visibility = Visibility.Visible;
            ZavesaGrid.Visibility = Visibility.Visible;
        }

        private void ZakluchenieTextBlockMouseDown(object sender, MouseButtonEventArgs e)
        {
            ZakluchenieWindow zakluchenie = new ZakluchenieWindow();
            zakluchenie.Show();
            this.Hide();
        }
    }
}
