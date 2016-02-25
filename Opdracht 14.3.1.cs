using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_14._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string uitkomst;
            Console.Write("Geef eerste getal: ");
            int getal1 = int.Parse(Console.ReadLine());

            Console.Write("Geef tweede getal: ");
            int getal2 = int.Parse(Console.ReadLine());

            int grootstegetal;
            int kleinstegetal;

            if (getal1 > getal2)
            {
                grootstegetal = getal1;
                kleinstegetal = getal2;
            }
            else
            { grootstegetal = getal2;
            kleinstegetal = getal1;
            }

            Console.Write("Kijk deze shit dan: " + grootstegetal);
            Console.ReadLine();

            Console.Write("EN DEZE DAN: " + kleinstegetal);
            Console.ReadLine();

         
         }
    }
}
