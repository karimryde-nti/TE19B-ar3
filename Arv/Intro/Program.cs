﻿using System;

namespace Intro
{
    /// <summary>
    /// Basklassen
    /// </summary>
    class Person
    {
        // prop
        public string Namn { get; set; }
        public string Mobil { get; set; }

        // ctor
        // Konstruktorn körs automatiskt vid "new"
        public Person(string namn, string mobil)
        {
            Namn = namn;
            Mobil = mobil;
        }

        // func
        // En virtuell metod kan man "skriva över"
        public virtual void VisaInfo()
        {
            Console.WriteLine($"Namn: {Namn}, Mobil: {Mobil}");
        }
    }

    // Klassen student utökar klassen person (bygger på)
    class Student : Person
    {
        public string Årskurs { get; set; }
        public string Program { get; set; }

        public Student(string n, string m, string årskurs, string program) : base(n, m)
        {
            Årskurs = årskurs;
            Program = program;
        }

        // En metode som "skriver över" basklassens metod
        public override void VisaInfo()
        {
            Console.WriteLine($"Namn: {Namn}, Mobil: {Mobil}");
            Console.WriteLine($"Årskurs: {Årskurs}, Program: {Program}");
        }
    }

    // Klassen Lärare utökar klassen person (bygger på)
    class Lärare : Person
    {
        public string AnställningÅr { get; set; }
        public string Ämnen { get; set; }

        public Lärare(string n, string m, string anställningÅr, string ämnen) : base(n, m)
        {
            AnställningÅr = anställningÅr;
            Ämnen = ämnen;
        }

        public override void VisaInfo()
        {
            Console.WriteLine($"Namn: {Namn}, Mobil: {Mobil}");
            Console.WriteLine($"AnställningÅr: {AnställningÅr}, Ämnen: {Ämnen}");
        }
    }

    // class
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arv - registrera personer på skolan");

            // while (true)
            // {
/*                 // Skapa en instans (objekt)
                Person person = new Person();  // Person är en instans av Person()

                Console.Write("Vad heter personen? ");
                person.Namn = Console.ReadLine();
                Console.Write("Vad är personens mobilnr? ");
                person.Mobil = Console.ReadLine();

                Console.Write("Mata en till? (j/n)");
                if (Console.ReadLine() != "j")
                    break;   */ 
            // }

            Person person = new Person("Max", "070546565"); 

            while (true)
            {
                // Skapa en instans (objekt)
                Student student = new Student();

                Console.Write("Vad heter student? ");
                student.Namn = Console.ReadLine();
                Console.Write("Vad är studentens mobilnr? ");
                student.Mobil = Console.ReadLine();
                Console.Write("Ange årskurs? ");
                student.Årskurs = Console.ReadLine();
                Console.Write("Ange Program? ");
                student.Program = Console.ReadLine();

                student.VisaInfo();

                Console.Write("Mata en till? (j/n)");
                if (Console.ReadLine() != "j")
                    break;      
            }
        }
    }
}
