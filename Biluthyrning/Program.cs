using System;
using System.Collections.Generic;

namespace Biluthyrningen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till biluthyrningen!");

            // Skapa ett första avtal = avta1
            Avtal avtal1 = new Avtal();

            Console.Write("Ange kundens personnr: ");
            avtal1.Personnr = Console.ReadLine();
            Console.Write("Ange bilens regnr: ");
            avtal1.RegNr = Console.ReadLine();
            Console.Write("Ange antal km: ");
            avtal1.Km = int.Parse(Console.ReadLine());
            Console.Write("Ange antal dygn: ");
            avtal1.Tidsram = int.Parse(Console.ReadLine());
            avtal1.Datum = DateTime.Today;

            // Räkna ut totala kostnaden
            Console.WriteLine($"Total hyran blir {avtal1.RäknaKostnad()}:-");
            Console.WriteLine($"Bilen skall åter {avtal1.RäknaInlämningsdatum()}");
        }
    }

    class Avtal
    {
        // Egenskaper
        public string Personnr {get; set;}
        public DateTime Datum {get; set;}
        public string RegNr {get; set;}
        public int Km {get; set;}
        public int Kostnad {get; set;}
        public int Tidsram {get; set;}

        // Privat variabler som bara ska användas inuti klassen
        private IDictionary<string, int> _bilar = new Dictionary<string, int> {
            {"ABC123", 500},
            {"DEF123", 400},
            {"GHI123", 199}
        };

        /// <summary>
        /// Räkna ut bilens dyngskostnad * antal dygn + 2:-/km
        /// </summary>
        /// <returns></returns>
        public int RäknaKostnad()
        {
            //Console.WriteLine(bilar["ABC123"]);           // => 500
            // @todo inte krascha om regnr inte finns
            // @todo 100 km ingår i hyran, bara betala för extra km
            Kostnad = _bilar[RegNr] * Tidsram + Km * 2;     
            return Kostnad;
        }

        /// <summary>
        /// Räkna ut datum + tidsram
        /// </summary>
        /// <returns></returns>
        public string RäknaInlämningsdatum()
        {
            return Datum.AddDays(Tidsram).ToString("dd MMMM yyyy");
        }
    }
}
