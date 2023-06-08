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
    /// Логика взаимодействия для Vazhno1StrWindow.xaml
    /// </summary>
    public partial class Vazhno1StrWindow : Window
    {
        public Vazhno1StrWindow()
        {
            InitializeComponent();
        }

        private void ZakrytButtonClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
