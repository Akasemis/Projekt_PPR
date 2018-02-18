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
        public MainWindow()
        {
            InitializeComponent();
            var serwer = new ServiceReference1.Service1Client();
            ile.Content = serwer.ile_wierszy();
            imie.Content += serwer.zwroc_imie(1);
            rasa.Content += serwer.zwroc_rase(1);
            wiek.Content += Convert.ToString(serwer.zwroc_wiek(1));
            kontakt.Content += serwer.zwroc_kontakt(1);
        }
    }
}
