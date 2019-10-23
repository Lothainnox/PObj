using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car("Renault", 1999);
            Console.WriteLine(car1.marka + ' ' + car1.rok);
            Console.ReadKey();

            /*var car2 = new Car("VW", 1997);
            Console.WriteLine(car2.marka + ' ' + car2.rok);
            Console.ReadKey();

            car1 = car2;
            Console.WriteLine(car2.marka + ' ' + car2.rok);
            Console.ReadKey();*/

        }
    }
}
