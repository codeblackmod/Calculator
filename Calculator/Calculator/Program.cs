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

        //Wenn man TODO gefolgt von ":" als Kommentar im VS Editor einfügt, kann unter dem Menüpunkt "View" die Task List anzeigen lassen
        //TODO: Test Todo

        static void Main(string[] args)
        {
            // User Story "Addieren": Als Benutzer möchte ich zwei Zahlen eingeben, um deren Summe berechnen zu lassen.
            string firstNumberAsString = GetUserInput("Please type in the first number: ");
            string secondNumberAsString = GetUserInput("Please type in the second number: ");
            string operation = GetUserInput("Please type in the operation you would like to use (+ or -): ");

            // Wandle Text in Dezimalzahl mittels extra Parameter
            double firstNumber = ConvertToDouble(firstNumberAsString);
            double secondNumber = ConvertToDouble(secondNumberAsString);
            double result = 0;

            if (operation == "+")
            {
                result = Add(firstNumber, secondNumber);
            }
            else if (operation == "-")
            {
                result = Substract(firstNumber, secondNumber);
            }

            // Ausgabe
            CalculateOutput("The sum is: ", result);

            GetUserInput("Press enter to exit!");
        }

        static double Substract(double minuend, double subtrahend)
        {
            double result = minuend - subtrahend;
            return result;
        }

        static void CalculateOutput(string outputText, double result)
        {
            Console.WriteLine(outputText + result);
        }

        static double ConvertToDouble(string no)
        {
            return Convert.ToDouble(no);
        }

        static string GetUserInput(string outputText)
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
    }
}
