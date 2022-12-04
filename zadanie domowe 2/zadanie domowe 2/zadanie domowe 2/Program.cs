using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_domowe_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3; 
            int b = 4; 
            int c = 5; 

            Console.WriteLine("bok a jest rowny: " + a);
            Console.WriteLine("bok b jest rowny: " + b);
            Console.WriteLine("bok c jest rowny: " + c);

            int poleKwadratuJeden = a * a;
            Console.WriteLine("Pole kwadratu z bokiem a wynosi: "  + poleKwadratuJeden);

            int poleKwadratuDwa = b * b;
            Console.WriteLine("Pole kwadratu z bokiem b wynosi: " + poleKwadratuDwa);

            int poleKwadratuTrzy = c * c;
            Console.WriteLine("Pole kwadrattu z bokiem c wynosi: " + poleKwadratuTrzy);


            // a) jesli pole kwadratu jest mniejsze niz 16 wypisz :pole kwadratu jest mniejsze niz 16"

            if (poleKwadratuJeden < 16)
                Console.WriteLine("Pole kwadratu jeden jest mniejsze niz 16");
            else if(poleKwadratuJeden >16)
                Console.WriteLine(" Pole kwadratu jeden jest większe niz 16");



            Console.ReadKey();

        }
       
    }
}
