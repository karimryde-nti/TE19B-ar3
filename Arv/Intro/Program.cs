using System;

namespace Intro
{
    class Person
    {
        // prop
        public string Namn { get; set; }
        public string Mobil { get; set; }

        // func
        // En virtuell metod kan man "skriva över"
        public virtual void VisaInfo()
        {
            Console.WriteLine($"Namn: {Namn}, Mobil: {Mobil}");
        }
    }

    class Student : Person
    {
        public string Årskurs { get; set; }
        public string Program { get; set; }

        // En metode som "skriver över" basklassens metod
        public override void VisaInfo()
        {
            Console.WriteLine($"Namn: {Namn}, Mobil: {Mobil}");
            Console.WriteLine($"Årskurs: {Årskurs}, Program: {Program}");
        }
    }

    class Lärare : Person
    {
        public string AnställningÅr { get; set; }
        public string Ämnen { get; set; }

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

/*             while (true)
            {
                // Skapa en instans (objekt)
                Person person = new Person();

                Console.Write("Vad heter personen? ");
                person.Namn = Console.ReadLine();
                Console.Write("Vad är personens mobilnr? ");
                person.Mobil = Console.ReadLine();

                Console.Write("Mata en till? (j/n)");
                if (Console.ReadLine() != "j")
                    break;      
            } */

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
