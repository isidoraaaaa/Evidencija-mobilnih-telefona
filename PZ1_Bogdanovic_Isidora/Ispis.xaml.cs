using System;
using System.Collections.Generic;
using System.IO;
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

namespace PZ1_Bogdanovic_Isidora
{
    public partial class Ispis : Window
    {

        TextRange ispis;

        public Ispis(int idx)
        {
            InitializeComponent();

            FileStream fileStream = new FileStream("_" + MainWindow.telefoni[idx].IMEI1 + "_", FileMode.Open);
            ispis = new TextRange(rtbx_opis.Document.ContentStart, rtbx_opis.Document.ContentEnd);
            ispis.Load(fileStream, DataFormats.Rtf);
            fileStream.Close();

            img_unos.Source = new BitmapImage(new Uri(MainWindow.telefoni[idx].Slika_telefona));

        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           this.DragMove();
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
