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
    /// Логика взаимодействия для RezultatWindow.xaml
    /// </summary>
    public partial class RezultatWindow : Window
    {
        public RezultatWindow(string perviy, string vtoroy, string tretiy, string chetvertiy, string piatiy, int bally)
        {
            InitializeComponent();
            VashOtvetOdinRun.Text = perviy;
            VashOtvetDvaRun.Text = vtoroy;
            VashOtvetTriRun.Text = tretiy;
            VashOtvetChetyreRun.Text = chetvertiy;
            VashOtvetPiatRun.Text = piatiy;
            VashRezultatRun.Text = bally.ToString();
        }

        private void KonvertirovatVPDFButtonClick(object sender, RoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
            {
                printDialog.PrintVisual(RezultatCanvas, "Otchet");
            }
        }
    }
}
