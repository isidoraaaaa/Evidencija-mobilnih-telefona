using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace PZ1_Bogdanovic_Isidora
{

    public partial class MainWindow : Window
    {
     
        public static BindingList<Telefoni> telefoni { get; set; }
        



        public MainWindow()
        {
            telefoni = new BindingList<Telefoni>();
            
            InitializeComponent();
            DataContext = this;
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            this.DragMove();

        }

        private void btn_izlaz_Click(object sender, RoutedEventArgs e)
        {

            MessageBoxResult result = MessageBox.Show("Da li ste sigurni da zelite da izadjete?", "Upozorenje", MessageBoxButton.OKCancel,MessageBoxImage.Warning);
            if (result.Equals(MessageBoxResult.OK))
                this.Close();


        }

        private void btn_dodaj_Click(object sender, RoutedEventArgs e)
        {
            Unos prozor = new Unos();
            prozor.ShowDialog();
        }

        private void btn_obrisi_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.telefoni.RemoveAt(dg_telefoni.SelectedIndex);
        }

        private void btn_izmeni_Click(object sender, RoutedEventArgs e)
        {
            Izmena iz = new Izmena(dg_telefoni.SelectedIndex);
                iz.ShowDialog();

        }

        private void btn_procitaj_Click(object sender, RoutedEventArgs e)
        {
            Ispis i = new Ispis(dg_telefoni.SelectedIndex);
            i.ShowDialog();
        }
    }
}
