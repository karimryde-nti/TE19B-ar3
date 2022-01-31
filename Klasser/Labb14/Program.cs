/* Skapa en klass som beskriver en Bok.
Du ska ha med följande egenskaper: Titel, Författare, AntalSidor.
Klassen ska också ha en metod SkrivUt som skriver ut bokens info.
Skriv ett program som använder klassen Bok och demonstrerar att den fungerar. */

using System;

namespace Labb14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.Write("Vad heter boken? ");
            string titel = Console.ReadLine();
            Console.Write("Vad heter författaren? ");
            string författare = Console.ReadLine();
            Console.Write("Ange antal sidor ");
            int antalSidor = int.Parse(Console.ReadLine());

            // Skapa ett objekt = bok av typen Bok
            // bok heter också instans av Bok
            // Skapa och ge värdena samtidigt!
            Bok bok = new Bok(titel, författare, antalSidor);

            // Skriv ut sammafattning
            bok.skrivUt();

        }
    }
}
