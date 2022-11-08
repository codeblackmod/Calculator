using System;

namespace Calculator
{
    class ApplicationController
    {
        private ConsoleView _view;
        private RechnerModel _model;

        public ApplicationController(ConsoleView view, RechnerModel model)
        {
            this._view = view;
            this._model = model;
        }

        public void Execute()
        {
            string firstNumberAsString = this._view.GetNumberFromUser();
            string operation = this._view.GetOperatorFromUser();
            string secondNumberAsString = this._view.GetNumberFromUser();

            // Wandle Text in Dezimalzahl mittels extra Parameter
            double firstNumber = ConvertToDouble(firstNumberAsString);
            double secondNumber = ConvertToDouble(secondNumberAsString);

            // Berechnung ausführen
            this._model.Calculate(operation, firstNumber, secondNumber);

            // Berechnung ausgeben
            this._view.ResultOutput(operation);

            this._view.GetUserInput("Press enter to exit!");
        }

        static double ConvertToDouble(string no)
        {
            return Convert.ToDouble(no);
        }
    }
}
