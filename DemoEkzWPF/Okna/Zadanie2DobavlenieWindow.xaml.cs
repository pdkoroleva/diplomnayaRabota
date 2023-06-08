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
    /// Логика взаимодействия для Zadanie2DobavlenieWindow.xaml
    /// </summary>
    public partial class Zadanie2DobavlenieWindow : Window
    {
        public Zadanie2DobavlenieWindow()
        {
            InitializeComponent();
        }

        private void KTeoriiButtonClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
