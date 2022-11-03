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
