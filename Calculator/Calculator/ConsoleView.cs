using System;

namespace Calculator
{
    class ConsoleView
    {
        public string GetUserInput(string outputText)
        {
            Console.Write(outputText);
            string addend = Console.ReadLine().Replace(",", ".");
            return addend;
        }

        public void ResultOutput(string operation, double result)
        {
            if (operation == "+" || operation == "-" || operation == "*" || operation == "/")
            {
                Console.WriteLine("The result is: " + result);
            }
            else
            {
                Console.WriteLine("Chosen operation not supported.");
            }
        }
    }
}
