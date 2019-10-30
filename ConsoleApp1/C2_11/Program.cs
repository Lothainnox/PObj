using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Osoba Dyrektor = new Osoba("Jan", "Kowalski", 1965, 89, 182, true, Plec.M);
            Dyrektor.plec = Plec.M;
            Console.WriteLine(Dyrektor.tytul() + " " + Dyrektor.imie + " " + Dyrektor.nazwisko + " " + Dyrektor.obliczWiek() + " " + Dyrektor.plec);
            Console.ReadKey();

            Osoba Pacjent = new Osoba("Adam", "Nowak", 1989, 75, 170, false, Plec.M);
            Console.WriteLine(Pacjent.bmi());
            Console.ReadKey();
        }
    }
}
