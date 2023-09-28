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

namespace Galeria4P
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        List<String> list = new List<String>();
        int numer_zdj = 0;
        public MainWindow()
        {
            InitializeComponent();
            list.Add("zdjecia/obraz1.jpg");
            list.Add("zdjecia/obraz2.jpg");
            list.Add("zdjecia/obraz3.jpg");
            list.Add("zdjecia/obraz4.jpg");
        }

        private void Button_Wybierz_Click(object sender, RoutedEventArgs e)
        {
            int numer;
            if(int.TryParse(numerzdjecia.Text,out numer))
            {
                
                if (numer < 0 || numer > list.Count)
                {
                    numer = 0;
                    MessageBox.Show("Niepoprawny numer zdjęcia");
                }
                    obrazek.Source = new BitmapImage(new Uri(list[numer], UriKind.Relative));
                    
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            numer_zdj--;
            if (numer_zdj < 0)
            {
                numer_zdj=list.Count-1;
            }
            obrazek.Source = new BitmapImage(new Uri(list[numer_zdj], UriKind.Relative));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            numer_zdj++;
            if(numer_zdj >= list.Count)
            { numer_zdj=0; }

            obrazek.Source = new BitmapImage(new Uri(list[numer_zdj], UriKind.Relative));
        }
    }
}
