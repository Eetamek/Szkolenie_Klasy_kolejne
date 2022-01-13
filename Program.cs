using System;
using Szkolenie_Klasy_kolejne;

namespace Szkolenie_Klasy_kolejne
{
    class Program
    {
        static void Main(string[] args)
        {
            MojaKlasa p1 = new MojaKlasa(5);
            MojaKlasa p2 = new MojaKlasa(p1); // wywołanie konstr. kopiującego
            Console.WriteLine("p1.Dana = {0}", p1.Dana);
            Console.WriteLine("p2.Dana = {0}", p2.Dana);
            p1.Dana = 8;
            Console.WriteLine("Wartości po zmianie obiektu p1");
            Console.WriteLine("p1.Dana = {0}", p1.Dana);
            Console.WriteLine("p2.Dana = {0}", p2.Dana);
            Console.ReadKey();
            Console.WriteLine("\n\n");


            Pracownik[] pracownicy = new Pracownik[3];
            pracownicy[0] = new Pracownik("Nowak", 4500);
            pracownicy[1] = new Pracownik("Kowalski", 3000);
            pracownicy[2] = new Pracownik("Abacki", 54000);

            foreach (var pracownik in pracownicy)
            {
                pracownik.PokazPracownika();
            }

            Console.WriteLine("Suma " + Pracownik.Sumuj(pracownicy));
            Console.ReadKey();

        }
    }
}
