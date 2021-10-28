using System;
using System.Collections.Generic;

namespace Listor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapa en array
            string[] städer = {"Berlin", "Paris", "London"};

            // Ett annat att skapa en tom array
            string[] frukter = new string[3];
            frukter[0] = "Äpple";
            frukter[1] = "Apelsin";
            frukter[2] = "Banan";

            // Skapa en lista av namn
            List<string> namnen = new List<string>() {"Miriam", "Teo", "Axel"};

            // Skapa en tom lista
            List<string> bären = new List<string>();
            bären.Add("Blåbär");
            bären.Add("Lingon");
            bären.Add("Hallon");
            bären.Add("Björnbär");
            bären.Add("Kråkbär");

            // Skriv ut alla frukter arrayen
            for (int i = 0; i < frukter.Length; i++)
            {
                Console.WriteLine(frukter[i]);
            }
            // En annan variant
            foreach (var frukt in frukter)
            {
                Console.WriteLine(frukt);
            }

            // Skriv alla bären i Listan
            for (int i = 0; i < bären.Count; i++)
            {
                Console.WriteLine(bären[i]);
            }

            // Om vi vill hitta en stad (array)
            foreach (var stad in städer)
            {
                if (stad == "Paris")
                {
                    Console.WriteLine("Paris finns i arrayen");
                }
            }

            // Om vi vill hitta ett bär (lista)
            if (bären.Contains("Blåbär"))
            {
                Console.WriteLine("Blåbär finns i listan");
            }

            // Ta bort ett bär
            bären.Remove("Hallon");
            bären.RemoveAt(0);
            bären.Insert(1, "Aroniabär");

            foreach (var bär in bären)
            {
                Console.WriteLine(bär);
            }
        }
    }
}
