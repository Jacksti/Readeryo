using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_14._2
{
    class Program
    {
        static double BerekenBTW(double bedrag)
        { 
        const double BTW_PERCENTAGE = 0.19;
        double btw;
        btw = bedrag * BTW_PERCENTAGE;
        return btw;
        }
        static void Main(string[] args)
        {
            string invoer;
            double prijs;
            double btw;
            double totaal;
            
            Console.WriteLine("Voer prijs in: ");
            invoer = Console.ReadLine();
            prijs = double.Parse(invoer);

            btw = BerekenBTW(prijs);
            Console.WriteLine("De BTW is: " + btw);
            Console.ReadLine();

            Console.WriteLine("De prijs is: " + prijs);
            Console.ReadLine();

            totaal = prijs + btw;
            Console.WriteLine("De totale prijs: " + totaal);
            Console.ReadLine();

           
        }
    }
}
