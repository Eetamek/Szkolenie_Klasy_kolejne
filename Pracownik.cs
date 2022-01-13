using System;
using System.Collections.Generic;
using System.Text;

namespace Szkolenie_Klasy_kolejne
{
    internal class Pracownik
    {
        public string Nazwisko { get; set; }
        public double Zarobki { get; set; }
        public Pracownik(string n, double z)
        {
            Nazwisko = n;
            Zarobki = z;
        }

        public void PokazPracownika()
        {
            Console.WriteLine("{0}{1,10}", Nazwisko, Zarobki);
        }
        public static double Sumuj(Pracownik[] tab)
        {
            double suma = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                suma += tab[i].Zarobki;

            }
            return suma;
        }

    }
}
