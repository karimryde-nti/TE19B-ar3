﻿using System;
using System.IO;
using System.Windows;

namespace Labb4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string[] rader;

        public MainWindow()
        {
            // Skapar fönstret och ritar ut elementen
            InitializeComponent();

            // Läs in alla rader från textfilen countries.csv
            rader = File.ReadAllLines("./countries.csv");
        }

        /// <summary>
        /// Det som händer när användaren klickar på Sök!
        /// </summary>
        private void ClickSök(Object sender, RoutedEventArgs e)
        {
            // Töm rutorna
            rutaResultat.Text = "";

            int antal = 1;

            // Fråga användare om en sökterm
            string sökterm = rutaSökterm.Text;

            // Loopa igenom alla rader
            foreach (var rad in rader)
            {
                // Dela upp raden
                string[] delar = rad.Split(',');

                // Plocka ut land
                string land = delar[1];

                // Plocka ut landskod
                string landskod = delar[2];

                // Hitta land som innehåller sökterm se https://www.geeksforgeeks.org/c-sharp-string-contains-method/
                if (land.ToLower().Contains(sökterm.ToLower()))
                {
                    // Skriv ut matchande land och dess landskod
                    rutaResultat.Text = $"{antal} {land}: {landskod}\n";
                    antal++;
                }
            }

            rutaStatus.Text = $"Hittade {antal - 1} länder";
        }
    }
}
