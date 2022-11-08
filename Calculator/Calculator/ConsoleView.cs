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

        public void GetInputsFromUserForFirstCalculation()
        {
            this._model.FirstNumber = GetNumberFromUser();
            this._model.Operation = GetOperatorFromUser();
            this._model.SecondNumber = GetNumberFromUser();
        }

        public void GetInputFromUserForFurtherCalculations()
        {
            string input = this.GetOperatorFromUser();
            if (input == "quit")
            {
                UserWantToQuit = true;
            }
            else
            {
                this._model.FirstNumber = this._model.Result;
                this._model.Operation = input;
                this._model.SecondNumber = this.GetNumberFromUser();
            }
        }

        private double GetNumberFromUser()
        {
            Console.Write("Insert a number for calculation: ");
            return this.ConvertToDouble(Console.ReadLine().Replace(",", "."));
        }
        private double ConvertToDouble(string no)
        {
            return Convert.ToDouble(no);
        }

        private string GetOperatorFromUser()
        {
            Console.Write("Insert an operator for calculation type (+, -, *, / or quit for exit): ");
            return Console.ReadLine();
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
