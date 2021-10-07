﻿using System;
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

namespace Labb5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Skapa en lista
        List<string> lista = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickLäggTill(object sender, RoutedEventArgs e)
        {
            // Läs in namnet
            string namn = rutaNamn.Text;

            // Läs in lönen
            string lön = rutaLön.Text;

            // Fyll på rutaLista med $"{namn}\t{lön}\n"
            rutaLista.Text += $"{namn}\t{lön}\n";

            // Lagra "{namn}\t{lön}" i lista
            lista.Add("{namn}\t{lön}");
        }

        private void ClickSpara(object sender, RoutedEventArgs e)
        {

        }
    }
}
