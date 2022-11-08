using System;

namespace Calculator
{
    class ConsoleView
    {
        private RechnerModel _model;

        public ConsoleView(RechnerModel model)
        {
            this._model = model;
        }

        public double GetNumberFromUser()
        {
            Console.Write("Insert a number for calculation: ");
            return ConvertToDouble(Console.ReadLine().Replace(",","."));
        }
        private static double ConvertToDouble(string no)
        {
            return Convert.ToDouble(no);
        }

        public string GetOperatorFromUser()
        {
            Console.Write("Insert an operator for calculation type (+, -, * or /): ");
            return Console.ReadLine();
        }

        public void WaitForExitThroughUser()
        {
            Console.WriteLine("To exit the calculater please press enter!");
            Console.ReadLine();
        }

        public string GetUserInput(string outputText)
        {
            Console.Write(outputText);
            string addend = Console.ReadLine().Replace(",", ".");
            return addend;
        }

        public void ResultOutput(string operation)
        {
            if (operation == "+" || operation == "-" || operation == "*" || operation == "/")
            {
                Console.WriteLine("The result is: " + _model.Result);
            }
            else
            {
                Console.WriteLine("Chosen operation not supported.");
            }
        }
    }
}
