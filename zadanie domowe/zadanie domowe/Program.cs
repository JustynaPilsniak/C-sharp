using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_domowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //oblicz pole kwadratu, pole prostokąta, obwód kwadratu, obwód prostokąta, zastosowanie console writeline, na końcu console readline
            int a = 6;
            Console.WriteLine("bok jest równy:" + a);

            int poleKwadratu = a * a;
            Console.WriteLine("Pole kwadratu wynosi:" + poleKwadratu);

            int obwodKwadratu = a + a + a + a;
            Console.WriteLine("Obwod kwadratu wynosi:" + obwodKwadratu);

            int b = 7;
            Console.WriteLine("pierwszy bok jest równy:" + b);

            int c= 5;
            Console.WriteLine("drugi bok jest równy:" + c);

            int poleProstokata = b * c;
            Console.WriteLine("pole prostokata wynosi:" + poleProstokata);

            int obwodProstokata = b + b + c + c;
            Console.WriteLine("Obwod kwadratu wynosi:" + obwodProstokata);

            Console.ReadLine();

        
        
        
        
        }





    }
}
