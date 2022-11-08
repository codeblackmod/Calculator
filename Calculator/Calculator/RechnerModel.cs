namespace Calculator
{
    class RechnerModel
    {
        public double Result { get; private set; }
        public string Operation { get; private set; }

        public RechnerModel()
        {
            Result = 0;
            Operation = "unknown";
        }
        public void Calculate(string operation, double firstNumber, double secondNumber)
        {
            this.Operation = operation;

            switch (operation)
            {
                case "+":
                    Result = this.Add(firstNumber, secondNumber);
                    break;

                case "-":
                    Result = this.Substract(firstNumber, secondNumber);
                    break;

                case "*":
                    Result = this.Multiplicate(firstNumber, secondNumber);
                    break;

                case "/":
                    Result = this.Divide(firstNumber, secondNumber);
                    break;
            }
        }

        private double Add(double firstNo, double secondNo)
        {
            double result = firstNo + secondNo;
            return result;
        }

        private double Substract(double minuend, double subtrahend)
        {
            double result = minuend - subtrahend;
            return result;
        }

        private double Multiplicate(double factor1, double factor2)
        {
            double result = factor1 * factor2;
            return result;
        }

        private double Divide(double dividend, double divisor)
        {
            double result = dividend / divisor;
            return result;
        }
    }
}
