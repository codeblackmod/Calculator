using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        // Methode definieren in 7 Schritten ...
        // Modifizierer definieren
        // Datentyp des Rückgabewertes definieren
        // Methodennamen definieren
        // Runde Klammern an den Methodennamen anfügen
        // Überlegen welche Parameter benötigt werden (optional diese definieren)
        // Geschweifte Klammern einfügen
        // Methode implementieren (Anweisungen in den Methodenkörper schreiben)

        static void Main(string[] args)
        {
            // User Story "Addieren": Als Benutzer möchte ich zwei Zahlen eingeben, um deren Summe berechnen zu lassen.
            string firstAddend = GetFirstAddend();
            string secondAddend = GetSecondAddend();

            // Wandle Text in Dezimalzahl mittels extra Parameter
            double firstAddendNo = ConvertToDouble(firstAddend);
            double secondAddendNo = ConvertToDouble(secondAddend);

            // Berechnung ausführen
            double result = Add(firstAddendNo, secondAddendNo);

            // Ausgabe ohne Gleitkommadarstellung
            Console.WriteLine("The sum is: {0}", result);

            WaitForUserInput();
        }

        static double ConvertToDouble(string no)
        {
            return Convert.ToDouble(no);
        }

        static string GetFirstAddend()
        {
            Console.Write("Please type in the first addend: ");
            return Console.ReadLine();
        }
        static string GetSecondAddend()
        {
            Console.Write("Please type in the second addend: ");
            return Console.ReadLine();
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
