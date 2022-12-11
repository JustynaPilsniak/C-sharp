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


            // a) jesli pole kwadratu jest mniejsze niz 16 wypisz :pole kwadratu jest mniejsze niz 16 "

            if (poleKwadratuJeden < 16)
                Console.WriteLine("Pole kwadratu jeden jest mniejsze niz 16");

            if (poleKwadratuDwa < 16)
                Console.WriteLine("Pole kwadratu dwa jest mniejsze niz 16");

            if (poleKwadratuTrzy < 16)  
                Console.WriteLine("Pole kwadratu trzy jest mniejsze niż 16");

            //b) jeeśli pole kwadratu jest mniejsze niż 20 wypisz "pole kwadratu jest mniejsze niż 20"

            if (poleKwadratuJeden < 20)
                Console.WriteLine("Pole kwadratu jeden jest mniejsze niż 20");

            if (poleKwadratuDwa < 20)
                Console.WriteLine("Pole kwadratu dwa jest mniejsze niż 20");

            if (poleKwadratuTrzy < 20)
                Console.WriteLine("Pole kwadratu trzy jest mnejsze niż 20");

            //c) jeśli pole kwadratu kwadratu jest mniejsze niż 30 wypisz "pole kwadratu jest mniejsze niż 30"

            if (poleKwadratuJeden < 30)
                Console.WriteLine("Pole kwadratu jeden jest mniejsze niż 30");

            if (poleKwadratuDwa < 30)
                Console.WriteLine("Pole kwadratu dwa jest mniejsze niż 30");

            if (poleKwadratuTrzy < 30)
                Console.WriteLine("Pole kwadratu trzy jest mniejsze niż 30");

            //d) dodatkowo wyświetl tekst "obwód kwadratu jest większy niż 12" jeśli obwód kwadratu jest większy niż 12

            int obwodKwadratuJeden = a + a + a + a;
            Console.WriteLine("Obwód kwadratu jeden wynosi: " + obwodKwadratuJeden);

            int obwodKwadratuDwa = b + b + b + b;
            Console.WriteLine("Obwód kwadratu dwa wynosi: " + obwodKwadratuDwa);

            int obwodKwadratuTrzy = c + c + c + c;  
            Console.WriteLine("Obwód kwadratu trzy wynosi: " + obwodKwadratuTrzy);

            if (obwodKwadratuJeden > 12)
                Console.WriteLine("Obwód kwadratu jeden jest większy niż 12");
            else if (obwodKwadratuJeden > 12)
                Console.WriteLine("Obwód kwadratu jeden jest większy niż 12");

            if (obwodKwadratuDwa > 12)
                Console.WriteLine("Obwód kwadratu dwa jest większy niż 12");
            else if (obwodKwadratuDwa > 12)
                Console.WriteLine("Obwód kwadratu dwa jest większy niż 12");

            if (obwodKwadratuTrzy > 12)
                Console.WriteLine("Obwód kwadratu trzy jest większy niż 12");
            else if (obwodKwadratuTrzy > 12)
                Console.WriteLine("Obwód kwadratu trzy jest większy niż 12");

            Console.ReadKey();

        }
       
    }
}
