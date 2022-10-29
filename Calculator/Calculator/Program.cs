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
            string firstAddend = GetAddend("Please type in the first addend: ");
            string secondAddend = GetAddend("Please type in the second addend: ");

            // Wandle Text in Dezimalzahl mittels extra Parameter
            double firstAddendNo = ConvertToDouble(firstAddend);
            double secondAddendNo = ConvertToDouble(secondAddend);

            // Berechnung ausführen
            double result = Add(firstAddendNo, secondAddendNo);

            // Ausgabe
            CalculateOutput("The sum is: ", result);

            WaitForUserInput();
        }

        static void CalculateOutput(string outputText, double result)
        {
            Console.WriteLine(outputText + result);
        }

        static double ConvertToDouble(string no)
        {
            return Convert.ToDouble(no);
        }

        static string GetAddend(string outputText)
        {
            Console.Write(outputText);
            string addend = Console.ReadLine().Replace(",",".");
            return addend;
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
