﻿using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Kompakt inmatning
                Console.Write("Förnamn Efternamn: ");
                string[] input = Console.ReadLine().Split(" ");
                
                // Kolla att vi fick två textbitar
                if (input.Length == 2)
                {
                    // Lagra i en instans (objekt)
                    Person person = new Person(input[0], input[1]);
                }
                else
                {
                    Console.WriteLine("Du måste mata in förnamn mellanrum efternam");
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
