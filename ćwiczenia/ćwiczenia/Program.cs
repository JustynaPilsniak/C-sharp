using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ćwiczenia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pudelkoLiczbCalkowitych = 5;
            
            float pudelkoLiczbPoPrzecinku = 2.5f;
            string pudelkoZeWszystkim = "a b c 5";
            string tylkoLiczba = "6";
            double pudelkoPelneLiczb = 657.89;
            string pudelkoBez = "88,2";


            int suma = pudelkoLiczbCalkowitych + pudelkoLiczbCalkowitych;
            Console.WriteLine(suma);

            double dodawania = pudelkoLiczbCalkowitych + pudelkoLiczbPoPrzecinku;
            Console.WriteLine(dodawania);

            int pudelkoLiczba = int.Parse(tylkoLiczba);
            Console.WriteLine(pudelkoLiczba);

            float pudelkoZNiespodzianka = float.Parse(pudelkoBez);

            pudelkoLiczba = 1;
            pudelkoLiczba = 5;
            pudelkoLiczba++;
            ++pudelkoLiczba;

            if (pudelkoLiczba < 6)
            {
                Console.WriteLine("liczba jest mniejsza niż 6"); 
            }    
            else if (pudelkoLiczba>6)
            {
                Console.WriteLine("Liczba jest większa niż 6");
            }
            else if (pudelkoLiczba>5)
            {
                Console.WriteLine("Liczba jest większa niż 5");
            }
            else
            {
                Console.WriteLine("Liczba jest równa 6 ");

            }

            Console.ReadLine();





        }
    }
}
