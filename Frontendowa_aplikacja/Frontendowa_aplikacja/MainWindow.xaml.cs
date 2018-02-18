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

namespace Frontendowa_aplikacja
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int stan = 1;
        public MainWindow()
        {
            InitializeComponent();
            var serwer = new ServiceReference1.Service1Client();
            imie_t.Content = serwer.zwroc_imie(1);
            rasa_t.Content = serwer.zwroc_rase(1);
            wiek_t.Content = Convert.ToString(serwer.zwroc_wiek(1));
            kontakt_t.Content = serwer.zwroc_kontakt(1);
        }

        private void zwierzak_next(object sender, RoutedEventArgs e)
        {
            var serwer = new ServiceReference1.Service1Client();
            int ile = serwer.ile_wierszy();
            if (stan < ile)
            {
                stan++;
                imie_t.Content = serwer.zwroc_imie(stan);
                rasa_t.Content = serwer.zwroc_rase(stan);
                wiek_t.Content = Convert.ToString(serwer.zwroc_wiek(stan));
                kontakt_t.Content = serwer.zwroc_kontakt(stan);
            }
            else
            {
                stan = 1;
                imie_t.Content = serwer.zwroc_imie(stan);
                rasa_t.Content = serwer.zwroc_rase(stan);
                wiek_t.Content = Convert.ToString(serwer.zwroc_wiek(stan));
                kontakt_t.Content = serwer.zwroc_kontakt(stan);
            }
        }

        private void zwierzak_prev(object sender, RoutedEventArgs e)
        {
            var serwer = new ServiceReference1.Service1Client();
            int ile = serwer.ile_wierszy();
            if (stan > 1)
            {
                stan--;
                imie_t.Content = serwer.zwroc_imie(stan);
                rasa_t.Content = serwer.zwroc_rase(stan);
                wiek_t.Content = Convert.ToString(serwer.zwroc_wiek(stan));
                kontakt_t.Content = serwer.zwroc_kontakt(stan);
            }
            else
            {
                stan = serwer.ile_wierszy();
                imie_t.Content = serwer.zwroc_imie(stan);
                rasa_t.Content = serwer.zwroc_rase(stan);
                wiek_t.Content = Convert.ToString(serwer.zwroc_wiek(stan));
                kontakt_t.Content = serwer.zwroc_kontakt(stan);
            }
        }
    }
}
