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
            double firstNumber = this._view.GetNumberFromUser();
            string operation = this._view.GetOperatorFromUser();
            double secondNumber = this._view.GetNumberFromUser();

            // Berechnung ausführen
            this._model.Calculate(operation, firstNumber, secondNumber);

            // Berechnung ausgeben
            this._view.ResultOutput();

            this._view.WaitForExitThroughUser();
        }
    }
}
