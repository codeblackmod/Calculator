namespace Calculator
{
    class RechnerModel
    {
        public double Calculate(string operation, double firstNumber, double secondNumber)
        {
            double result = 0;
            switch (operation)
            {
                case "+":
                    result = this.Add(firstNumber, secondNumber);
                    break;

                case "-":
                    result = this.Substract(firstNumber, secondNumber);
                    break;

                case "*":
                    result = this.Multiplicate(firstNumber, secondNumber);
                    break;

                case "/":
                    result = this.Divide(firstNumber, secondNumber);
                    break;
            }
            return result;
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
