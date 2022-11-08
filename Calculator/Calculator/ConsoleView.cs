using System;
using System.Collections.Generic;

namespace Calculator
{
    class ConsoleView
    {
        private RechnerModel _model;

        public bool UserWantToQuit { get; private set; }

        public ConsoleView(RechnerModel model)
        {
            this._model = model;
            UserWantToQuit = false;
        }

        public void GetInputsFromUser()
        {
            this._model.FirstNumber = GetNumberFromUser();
            this._model.Operation = GetOperatorFromUser();
            this._model.SecondNumber = GetNumberFromUser();
        }
            
        private double GetNumberFromUser()
        {
            string input;
            Console.Write("Insert a number for calculation (Quit for exit): ");
            input = Console.ReadLine().Replace(",",".");

            if (input == "Quit")
            {
                UserWantToQuit = true;
                input = "0.0";
            }

            return ConvertToDouble(input);
        }
        private double ConvertToDouble(string no)
        {
            return Convert.ToDouble(no);
        }

        private string GetOperatorFromUser()
        {
            Console.Write("Insert an operator for calculation type (+, -, * or /): ");
            return Console.ReadLine();
        }

        public void WaitForExitThroughUser()
        {
            Console.WriteLine("To exit the calculater please press enter!");
            Console.ReadLine();
        }

        public void ResultOutput()
        {
            List<string> supportedOperations = new List<string> { "+", "-", "*", "/" };

            if (supportedOperations.Contains(this._model.Operation))
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
