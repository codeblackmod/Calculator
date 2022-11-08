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
            while (!this._view.UserWantToQuit)
            {
                this._view.GetInputsFromUser();

                this._model.Calculate();

                this._view.ResultOutput();
            }

            this._view.WaitForExitThroughUser();
        }
    }
}
