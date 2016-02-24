using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_14._3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            string cijfer;    
            //lees getal
            Console.Write("Geef de score: ");
            int getal = int.Parse(Console.ReadLine());
            
            //getal
            //>89
            if (getal > 89)
                 cijfer = "A";
            //>79
            else if (getal > 79)
                cijfer = "B";
            //>69
            else if (getal > 69)
                cijfer = "C";
            //>59
            else if (getal > 59)
                cijfer = "D";
            //anders
            else
                cijfer = "F";
            string gehaald;
            //cijfer = A B of C
            if (cijfer == "A" | cijfer == "B" | cijfer == "C")
            //ja: gehaald = vak gehaald
                gehaald = "Vak gehaald";
            //nee: gehaald = vak niet gehaald
            else
                gehaald = "Vak niet gehaald";
            //toon cijfer, gehaald
            Console.WriteLine("Je hebt een '{0}' cijfer", cijfer);
            Console.WriteLine("Dus heb je het {0}.", gehaald);
            Console.ReadLine();
        }
    }
}
