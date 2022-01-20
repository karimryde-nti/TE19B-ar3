using System;
using System.Collections.Generic;

namespace Biluthyrningen
{
    class Program
    {
        // För att spara alla avtal
        static List<Avtal> listaAvtal = new List<Avtal>();

        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till biluthyrningen!");

            string svar = "j";
            while (svar == "j")
            {
                // Skapa ett avtal
                Avtal avtal = new Avtal();

                // Spara avtalet i listan
                listaAvtal.Add(avtal);

                Console.Write("Ange kundens personnr: ");
                avtal.Personnr = Console.ReadLine();

                Console.Write("Ange bilens regnr: ");
                avtal.RegNr = Console.ReadLine();
                while (!avtal.finnsRegnr())
                {
                    Console.Write("Ange bilens regnr: ");
                    avtal.RegNr = Console.ReadLine();
                }

                Console.Write("Ange antal extra km: ");
                avtal.Km = int.Parse(Console.ReadLine());
                Console.Write("Ange antal dygn: ");
                avtal.Tidsram = int.Parse(Console.ReadLine());
                avtal.Datum = DateTime.Today;

                // Räkna ut totala kostnaden
                Console.WriteLine($"Total hyran blir {avtal.RäknaKostnad()}:-");
                Console.WriteLine($"Bilen skall åter {avtal.RäknaInlämningsdatum()}");

                Console.WriteLine("Vill du mata in ett till avtal? (j/n)");
                svar = Console.ReadLine().ToLower();
            }
        }
    }

    class Avtal
    {
        // Egenskaper
        public string Personnr { get; set; }
        public DateTime Datum { get; set; }
        public string RegNr { get; set; }
        public int Km { get; set; }
        public int Kostnad { get; set; }
        public int Tidsram { get; set; }

        // Privat variabler som bara ska användas inuti klassen
        private IDictionary<string, int> _bilar = new Dictionary<string, int> {
            {"ABC123", 500},
            {"DEF123", 400},
            {"GHI123", 199}
        };

        public bool finnsRegnr()
        {
            if (_bilar.ContainsKey(RegNr))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Räkna ut bilens dyngskostnad * antal dygn + 2:-/km
        /// </summary>
        /// <returns></returns>
        public int RäknaKostnad()
        {
            //Console.WriteLine(bilar["ABC123"]);           // => 500
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
