using System;
using System.IO;
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

namespace SamlaNamn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Global lista
        List<string> namnlista = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickLäggTill(object sender, RoutedEventArgs e)
        {
            // Läs av rutaNamn
            string namn = rutaNamn.Text;

            // Om rutaNamn ej tom 
            // Lägg till i rutaLista
            // Och lagra i en lista
            if (namn != "")
            {
                rutaLista.Text += $"{namn}\n";
                namnlista.Add(namn);
            }
            else
            {
                rutaFel.Text = "Namn är tomt!";
            }
        }

        private void ClickSpara(object sender, RoutedEventArgs e)
        {
            File.WriteAllLines("namnlist.txt", namnlista);
            rutaFel.Text = "Namnen sparade i namnlista.txt!";
        }
    }
}
