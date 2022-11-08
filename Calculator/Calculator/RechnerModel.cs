namespace Calculator
{
    class RechnerModel
    {
        public double Result { get; private set; }
        public string Operation { get; set; }
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }


        public RechnerModel()
        {
            Result = 0;
            Operation = "unknown";
        }
        public void Calculate()
        {
            switch (Operation)
            {
                case "+":
                    Result = this.Add(FirstNumber, SecondNumber);
                    break;

                case "-":
                    Result = this.Substract(FirstNumber, SecondNumber);
                    break;

                case "*":
                    Result = this.Multiplicate(FirstNumber, SecondNumber);
                    break;

                case "/":
                    Result = this.Divide(FirstNumber, SecondNumber);
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
