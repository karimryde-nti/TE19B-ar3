using System;

namespace Labb14
{
    public class Bok
    {
        // 3 egenskaper
        private string Titel { get; set; }
        private string Författare { get; set; }
        private int AntalSidor { get; set; }

        // Konstruktor = speciell metod
        public Bok(string _titel, string _författare, int _antalSidor)
        {
            Titel = _titel;
            Författare = _författare;
            AntalSidor = _antalSidor;
        }

        // 1 metod
        public void skrivUt()
        {
            Console.WriteLine($"Boken heter {Titel}, författaren är {Författare}, och antal sidor är {AntalSidor}");
        }
    }
}