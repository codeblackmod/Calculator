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
            RechnerModel model = new RechnerModel();
            ConsoleView view = new ConsoleView(model);

            string firstNumberAsString = view.GetNumberFromUser();
            string operation = view.GetOperatorFromUser();
            string secondNumberAsString = view.GetNumberFromUser();

            // Wandle Text in Dezimalzahl mittels extra Parameter
            double firstNumber = ConvertToDouble(firstNumberAsString);
            double secondNumber = ConvertToDouble(secondNumberAsString);

            // Berechnung ausführen
            model.Calculate(operation, firstNumber, secondNumber);

            // Berechnung ausgeben
            view.ResultOutput(operation);

            view.GetUserInput("Press enter to exit!");
        }

        static double ConvertToDouble(string no)
        {
            return Convert.ToDouble(no);
        }        
    }
}
