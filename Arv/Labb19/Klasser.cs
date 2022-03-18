using System;

namespace Labb19
{
    public class Media
    {
        virtual public string TillText()
        {
            return null;
        }
    }
    public class Bok : Media
    {
        public string Titel { get; set; }
        public string Författare { get; set; }
        public string AntalSidor { get; set; }

        public Bok(string titel, string författare, string antalSidor)
        {
            Titel = titel;
            Författare = författare;
            AntalSidor = antalSidor;
        }

        override public string TillText()
        {
            return($"{Titel} ({Författare} {AntalSidor})");
        }
    }
    public class Film : Media
    {
        public string Titel { get; set; }
        public string Regissör { get; set; }
        public string Längd { get; set; }

        public Film(string titel, string regissör, string längd)
        {
            Titel = titel;
            Regissör = regissör;
            Längd = längd;
        }

        override public string TillText()
        {
            return($"{Titel} ({Regissör} {Längd})");
        }
    }
}