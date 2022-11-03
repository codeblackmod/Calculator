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
            ConsoleView view = new ConsoleView();
            string firstNumberAsString = view.GetUserInput("Please type in the first number: ");
            string secondNumberAsString = view.GetUserInput("Please type in the second number: ");
            string operation = view.GetUserInput("Please type in the operation you would like to use (+, -, * or /): ");

            // Wandle Text in Dezimalzahl mittels extra Parameter
            double firstNumber = ConvertToDouble(firstNumberAsString);
            double secondNumber = ConvertToDouble(secondNumberAsString);

            // Berechnung ausführen
            RechnerModel model = new RechnerModel();
            model.Calculate(operation, firstNumber, secondNumber);

            // Berechnung ausgeben
            view.ResultOutput(operation, model.Result);

            view.GetUserInput("Press enter to exit!");
        }

        static double ConvertToDouble(string no)
        {
            return Convert.ToDouble(no);
        }        
    }
}
