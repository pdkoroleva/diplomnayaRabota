using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Логика взаимодействия для ZakluchenieWindow.xaml
    /// </summary>
    public partial class ZakluchenieWindow : Window
    {
        public ZakluchenieWindow()
        {
            InitializeComponent();
            MenuGrid.Visibility = Visibility.Collapsed;
            ZavesaGrid.Visibility = Visibility.Collapsed;
        }

        private void NazadButtonClick(object sender, RoutedEventArgs e)
        {
            FiltraciaWindow filtracia = new FiltraciaWindow();
            filtracia.Show();
            this.Hide();
        }

        private void ZakrytMenuButtonClick(object sender, RoutedEventArgs e)
        {
            MenuGrid.Visibility = Visibility.Collapsed;
            ZavesaGrid.Visibility = Visibility.Collapsed;
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

        private void FatalnyeOshTextBlockMouseDown(object sender, MouseButtonEventArgs e)
        {
            FatalnyeOshibkiWindow fatalnyeOshibki = new FatalnyeOshibkiWindow();
            fatalnyeOshibki.Show();
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

        private void StrukturaTextBlockMouseDown(object sender, MouseButtonEventArgs e)
        {
            StrukturaWindow struktura = new StrukturaWindow();
            struktura.Show();
            this.Hide();
        }

        private void SsylkaRunMouseDown(object sender, MouseButtonEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://disk.yandex.ru/d/qDFtNfOQJ1Vdvg");
            Process.Start(sInfo);
        }

        private void RezultatButtonClick(object sender, RoutedEventArgs e)
        {
            try
            {
                int bally = 0;

                if (PerviyPravilniyRadioButton.IsChecked == true)
                {
                    bally = bally + 1;
                }
                else if (PerviyNepravilniy1RadioButton.IsChecked == true || PerviyNepravilniy2RadioButton.IsChecked == true)
                {
                    bally = bally + 0;
                }

                if (VtoroyPravilniyRadioButton.IsChecked == true)
                {
                    bally = bally + 1;
                }
                else if (VtoroyNepravilniy1RadioButton.IsChecked == true || VtoroyNepravilniy2RadioButton.IsChecked == true)
                {
                    bally = bally + 0;
                }

                if (TretiyPravilniyRadioButton.IsChecked == true)
                {
                    bally = bally + 1;
                }
                else if (TretiyNepravilniy1RadioButton.IsChecked == true || TretiyNepravilniy2RadioButton.IsChecked == true)
                {
                    bally = bally + 0;
                }

                if (ChetvertiyPravilniyRadioButton.IsChecked == true)
                {
                    bally = bally + 1;
                }
                else if (ChetvertiyNepravilniy1RadioButton.IsChecked == true || ChetvertiyNepravilniy2RadioButton.IsChecked == true)
                {
                    bally = bally + 0;
                }

                if (PiatiyPravilniyRadioButton.IsChecked == true)
                {
                    bally = bally + 1;
                }
                else if (PiatiyNepravilniy1RadioButton.IsChecked == true || PiatiyNepravilniy2RadioButton.IsChecked == true)
                {
                    bally = bally + 0;
                }

                string perviy = null;
                if (PerviyPravilniyRadioButton.IsChecked == true)
                    perviy = "try {} catch {}";
                if (PerviyNepravilniy1RadioButton.IsChecked == true)
                    perviy = "if () {} else {}";
                if (PerviyNepravilniy2RadioButton.IsChecked == true)
                    perviy = "switch () {case: ...}";

                string vtoroy = null;
                if (VtoroyPravilniyRadioButton.IsChecked == true)
                    vtoroy = "Прописать атрибуты TabIndex";
                if (VtoroyNepravilniy1RadioButton.IsChecked == true)
                    vtoroy = "Пересоздать все элементы";
                if (VtoroyNepravilniy2RadioButton.IsChecked == true)
                    vtoroy = "Прописать атрибуты Tab для элементов";

                string tretiy = null;
                if (TretiyPravilniyRadioButton.IsChecked == true)
                    tretiy = "BackButton";
                if (TretiyNepravilniy1RadioButton.IsChecked == true)
                    tretiy = "BackKnopka";
                if (TretiyNepravilniy2RadioButton.IsChecked == true)
                    tretiy = "Nazad";

                string chetvertiy = null;
                if (ChetvertiyPravilniyRadioButton.IsChecked == true)
                    chetvertiy = "Сортировка";
                if (ChetvertiyNepravilniy1RadioButton.IsChecked == true)
                    chetvertiy = "Поиск";
                if (ChetvertiyNepravilniy2RadioButton.IsChecked == true)
                    chetvertiy = "Фильтрация";

                string piatiy = null;
                if (PiatiyPravilniyRadioButton.IsChecked == true)
                    piatiy = "Через связанную таблицу Роли и ее код в таблице пользователей";
                if (PiatiyNepravilniy1RadioButton.IsChecked == true)
                    piatiy = "Прописать в обработке кнопки 'Войти' вход для каждого пользователя";
                if (PiatiyNepravilniy2RadioButton.IsChecked == true)
                    piatiy = "По имени пользователя";


                RezultatWindow rezultat = new RezultatWindow(perviy, vtoroy, tretiy, chetvertiy, piatiy, bally);
                rezultat.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка, проверьте данные и попробуйте снова позже.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
