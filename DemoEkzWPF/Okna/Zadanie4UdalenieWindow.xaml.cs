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
    /// Логика взаимодействия для Zadanie4UdalenieWindow.xaml
    /// </summary>
    public partial class Zadanie4UdalenieWindow : Window
    {
        public Zadanie4UdalenieWindow()
        {
            InitializeComponent();
        }

        private void KTeoriiButtonClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
