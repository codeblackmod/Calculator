using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // User Story "Addieren": Als Benutzer möchte ich zwei Zahlen eingeben, um deren Summe berechnen zu lassen.
            Console.Write("Please type in the first addend: ");
            string firstAddend = Console.ReadLine().Replace(',', '.');

            Console.Write("Please type in the second addend: ");
            string secondAddend = Console.ReadLine().Replace(',', '.');

            // Wandle Text in Dezimalzahl mittels extra Parameter
            double firstAddendNo = Convert.ToDouble(firstAddend);
            double secondAddendNo = Convert.ToDouble(secondAddend);

            // Berechnung ausführen
            double result = Add(firstAddendNo, secondAddendNo);

            // Ausgabe ohne Gleitkommadarstellung
            Console.WriteLine("The sum is: {0}", result);

            WaitForUserInput();
        }

        static double Add(double firstNo, double secondNo)
        {
            double result = firstNo + secondNo;
            return result;
        }

        static void WaitForUserInput()
        {
            Console.Write("Press enter to exit!");
            Console.ReadLine();
        }
    }
}
