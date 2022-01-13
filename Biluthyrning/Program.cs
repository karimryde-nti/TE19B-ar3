// https://www.tutorialsteacher.com/csharp/csharp-dictionary

using System.ComponentModel;
using System.Collections.Generic;
using System;

namespace Biluthyrning
{
    // Kostnad för bilarna
    // Volvo ABC123 -> 500:-/d
    // Saab DEF456 -> 400:-/d
    // Fiat GHI789 -> 199:-/d
    // Extra km = 2:-/km,
    // Array? 
    // [
    //     ["ABC123", "500"], 
    //     ["DEF456", "400"], 
    //     ["GHI789", "199"]
    // ]

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till biluthyrningen!");
            Console.WriteLine("Ange kundens personnr: ");
            Console.WriteLine("Ange bilens regnr: ");
            Console.WriteLine("Ange antal km: ");
            Console.WriteLine("Ange antal dygn: ");

            //Avtal avtal1 = new Avtal();
        }
    }

    class Avtal
    {
        // Egenskaper
        public DateTime Datum { get; set; }
        public string RegNr { get; set; }
        public int Km { get; set; }
        public int Kostnad { get; set; }
        public int Tidsram { get; set; }
        public string Personnr { get; set; }

        // Private variabel
        private IDictionary<string, int> _bilar = new Dictionary<string, int>(){
            {"ABC123", 500},
            {"DEF456", 400},
            {"GHI789", 199}
        };

/*         public Avtal()
        {
            Console.WriteLine(_bilar["ABC123"]);
        } */
    }
}