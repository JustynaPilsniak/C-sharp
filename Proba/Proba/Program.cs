using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proba
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Console.WriteLine("Podaj promień kuli");
              string promien = Console.ReadLine();
              double promienKuli;
              double.TryParse(promien, out promienKuli);
              double objetoscKuli = 4.0 / 3 * Math.PI * Math.Pow(promienKuli, 3);
              Console.WriteLine("Obj kuli o r={0} wynosi {1}, promienKuli, objetoscKuli");
              */

            Console.WriteLine("Podaj promień kuli");
            string promien = Console.ReadLine();
            double promienKuli;
            double.TryParse(promien, out promienKuli);
            double objetoscKuli = 4.0 / 3 * Math.PI * Math.Pow(promienKuli, 3);
            Console.WriteLine("Obj kuli o r={0} wynosi {1}" , promienKuli, objetoscKuli);




            Console.ReadKey();

        }
    }
}
