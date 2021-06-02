using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    public partial class Izmena : Window
    {
        TextRange izmena;

        public int Idx { get; }

        public Izmena(int idx)
        {
            InitializeComponent();
            tb_IMEI.Text = MainWindow.telefoni[idx].IMEI1;
            cb_model.ItemsSource = Verzije_Telefona.verzije;
            cb_model.SelectedValue = MainWindow.telefoni[idx].Model_telefona;
            tb_datum.Text = MainWindow.telefoni[idx].Datum_izlaska_telefona;
            tb_kapacitet.Text = MainWindow.telefoni[idx].Interna_memorija;
            cmb_toolbar_velicina_fonta.ItemsSource = FontBoja.font_velicina;
            cmb_toolbar_FontFamily.ItemsSource = Fonts.SystemFontFamilies.OrderBy(f => f.Source);
            cmb_toolbar_boja.ItemsSource = FontBoja.lista_boja;
            if (MainWindow.telefoni[idx].Tip_sim == 2)
                rb_dual_SIM.IsChecked = true;
            if (MainWindow.telefoni[idx].Tip_sim == 1)
                rb_single_SIM.IsChecked = true;
            img_unos.Source = new BitmapImage(new Uri(MainWindow.telefoni[idx].Slika_telefona));

            FileStream fileStream = new FileStream(MainWindow.telefoni[idx].RTF_IME1, FileMode.Open);
            izmena = new TextRange(rtbx_opis.Document.ContentStart, rtbx_opis.Document.ContentEnd);
            izmena.Load(fileStream, DataFormats.Rtf);
            fileStream.Close();
            Idx = idx;
        }

        bool Validacija()
        {
            bool validacija = true; //optimisticno programiranje xd
            TextRange txt = new TextRange(rtbx_opis.Document.ContentStart, rtbx_opis.Document.ContentEnd);
            if (tb_IMEI.Text.Trim().Equals(string.Empty) || tb_IMEI.Text.Trim().Equals("Unesite IMEI"))
            {
                tb_IMEI.BorderBrush = Brushes.Red;
                tb_IMEI.BorderThickness = new Thickness(1);
                validacija = false;

            }

            else
            {
                tb_IMEI.BorderBrush = Brushes.Black;
                tb_IMEI.BorderThickness = new Thickness(1);
            }

            if (cb_model.SelectedValue.ToString().Trim().Equals("Izaberite verziju telefona"))
                validacija = false;

            else
            {
                cb_model.BorderBrush = Brushes.Black;
                cb_model.BorderThickness = new Thickness(1);
            }

            if (tb_datum.Text.Trim().Equals(string.Empty) || tb_datum.Text.Trim().Equals("Unesite datum") ||
                new Regex("^(0?[1-9]|1[0-9]|2[0-9]|3[01])[-](0?[1-9]|1[012])[-][0-9]{4}$").IsMatch(tb_datum.Text.Trim()) != true)
            {
                tb_datum.BorderBrush = Brushes.Red;
                tb_datum.BorderThickness = new Thickness(1);
                validacija = false;

            }

            else
            {
                tb_datum.BorderBrush = Brushes.Black;
                tb_datum.BorderThickness = new Thickness(1);
            }


            if (tb_kapacitet.Text.Trim().Equals(string.Empty) || tb_kapacitet.Text.Trim().Equals("Unesite kapacitet"))
            {
                tb_kapacitet.BorderBrush = Brushes.Red;
                tb_kapacitet.BorderThickness = new Thickness(1);
                validacija = false;

            }
            else
            {
                tb_kapacitet.BorderBrush = Brushes.Black;
                tb_kapacitet.BorderThickness = new Thickness(1);
            }

            if (txt.Text.Trim().Equals(string.Empty) || txt.Text.Trim().Equals("Unesite dodatne informacije o uredjaju ovde"))
            {
                rtbx_opis.BorderBrush = Brushes.Red;
                rtbx_opis.BorderThickness = new Thickness(1);
                validacija = false;
            }

            else
            {
                rtbx_opis.BorderBrush = Brushes.Black;
                rtbx_opis.BorderThickness = new Thickness(1);
            }

            if (img_unos.Source == null)
            {
                MessageBox.Show("GRESKA, morate uneti sliku!");
                validacija = false;
            }

            if (rb_single_SIM.IsChecked == false && rb_dual_SIM.IsChecked == false)
            {
                rb_single_SIM.BorderBrush = Brushes.Red;
                rb_single_SIM.BorderThickness = new Thickness(1);
                rb_dual_SIM.BorderBrush = Brushes.Red;
                rb_dual_SIM.BorderThickness = new Thickness(1);
                validacija = false;
            }
            else
            {
                rb_single_SIM.BorderBrush = Brushes.Black;
                rb_single_SIM.BorderThickness = new Thickness(1);
                rb_dual_SIM.BorderBrush = Brushes.Black;
                rb_dual_SIM.BorderThickness = new Thickness(1);
            }

            return validacija;
        }

        private void tb_IMEI_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tb_IMEI.Text.Trim().Equals("Unesite IMEI"))
                tb_IMEI.Text = string.Empty;
        }

        private void tb_IMEI_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tb_IMEI.Text.Trim().Equals(string.Empty))
            {
                tb_IMEI.Text = "Unesite IMEI";
            }
        }

        private void tb_datum_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tb_datum.Text.Trim().Equals("Unesite datum"))
                tb_datum.Text = string.Empty;
        }

        private void tb_datum_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tb_datum.Text.Trim().Equals(string.Empty))
                tb_datum.Text = "Unesite datum";
        }

        private void tb_kapacitet_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tb_kapacitet.Text.Trim().Equals("Unesite kapacitet"))
                tb_kapacitet.Text = string.Empty;
        }

        private void tb_kapacitet_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tb_kapacitet.Text.Trim().Equals(string.Empty))
                tb_kapacitet.Text = "Unesite kapacitet";
        }

        private void btn_add_sliku_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Izaberite sliku";
            if (op.ShowDialog() == true)
                img_unos.Source = new BitmapImage(new Uri(op.FileName));
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            if (Validacija())
            {
                if (rb_dual_SIM.IsChecked == true)
                    MainWindow.telefoni[Idx] = new Telefoni(img_unos.Source.ToString(), tb_IMEI.Text, cb_model.SelectedValue.ToString(), tb_datum.Text, tb_kapacitet.Text, 2, "_" + tb_IMEI.Text + "_");
                if (rb_single_SIM.IsChecked == true)
                    MainWindow.telefoni[Idx] = new Telefoni(img_unos.Source.ToString(), tb_IMEI.Text, cb_model.SelectedValue.ToString(), tb_datum.Text, tb_kapacitet.Text, 1, "_" + tb_IMEI.Text + "_");

                FileStream fileStream = new FileStream(MainWindow.telefoni[Idx].RTF_IME1, FileMode.Create); ;
                izmena = new TextRange(rtbx_opis.Document.ContentStart, rtbx_opis.Document.ContentEnd);
                izmena.Save(fileStream, DataFormats.Rtf);
                fileStream.Close();

                MessageBox.Show("Telefon uspesno izmenjen!", "Obavestenje", MessageBoxButton.OK, MessageBoxImage.Information);

            }
        }

            private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void rtbx_opis_SelectionChanged(object sender, RoutedEventArgs e)
        {
            TextRange rtb_string = new TextRange(rtbx_opis.Document.ContentStart, rtbx_opis.Document.ContentEnd);

            int br_reci = Regex.Matches(rtb_string.Text, @"[^\s]+").Count;
            tb_broj_reci.Text = "Broj reci: " + " [ " + br_reci + " ].";


            object bold = rtbx_opis.Selection.GetPropertyValue(Inline.FontWeightProperty);
            btn_toolbar_bold.IsChecked = (bold != DependencyProperty.UnsetValue) && (bold.Equals(FontWeights.Bold));

            object italic = rtbx_opis.Selection.GetPropertyValue(Inline.FontStyleProperty);
            btn_toolbar_italic.IsChecked = (italic != DependencyProperty.UnsetValue) && (italic.Equals(FontStyles.Italic));

            object underline = rtbx_opis.Selection.GetPropertyValue(Inline.TextDecorationsProperty);

            btn_toolbar_underline.IsChecked = (underline != DependencyProperty.UnsetValue) && (underline.Equals(TextDecorations.Underline));

            object font = rtbx_opis.Selection.GetPropertyValue(Inline.FontFamilyProperty);
            cmb_toolbar_FontFamily.SelectedItem = font;
        }

        private void cmb_toolbar_FontFamily_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmb_toolbar_FontFamily.SelectedItem != null)
                rtbx_opis.Selection.ApplyPropertyValue(Inline.FontFamilyProperty, cmb_toolbar_FontFamily.SelectedItem);
        }

        private void cmb_toolbar_velicina_fonta_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmb_toolbar_velicina_fonta.SelectedItem != null)
                rtbx_opis.Selection.ApplyPropertyValue(Inline.FontSizeProperty, cmb_toolbar_velicina_fonta.SelectedItem);
        }

        private void cmb_toolbar_boja_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmb_toolbar_boja.SelectedItem != null)
                rtbx_opis.Selection.ApplyPropertyValue(Inline.ForegroundProperty, cmb_toolbar_boja.SelectedItem);
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
