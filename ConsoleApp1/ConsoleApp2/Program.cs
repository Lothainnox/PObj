using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Produkt chleb = new Produkt("Chleb", 2.50);
            Produkt mleko = new Produkt("Mleko", 2.15);
            Koszyk koszyk1 = new Koszyk();
            koszyk1.DodajProdukt(chleb);
            Console.WriteLine(koszyk1.IleProduktow());
            Console.ReadKey();
            koszyk1.DodajProdukt(mleko);
            Console.WriteLine(koszyk1.IleProduktow());
            Console.ReadKey();
            Console.WriteLine(koszyk1.WartoscKoszyka());
            Console.ReadKey();
        }
    }
}
