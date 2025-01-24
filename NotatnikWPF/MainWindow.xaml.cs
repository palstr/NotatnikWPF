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

namespace NotatnikWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click_Nowy(object sender, RoutedEventArgs e)
        {
            wpisanyTekstTextBox.Text = String.Empty;
        }

        private void MenuItem_Click_oAutorze(object sender, RoutedEventArgs e)
        {
            //OKNO MODALNE

            WindowAutor windowAutor = new WindowAutor();
            windowAutor.ShowDialog();
        }

        private void MenuItem_Click_oAplikacji(object sender, RoutedEventArgs e)
        {
            //OKNO NIEMODALNE

            WindowAppka windowApka = new WindowAppka();
            windowApka.Show();
        }
    }
}
