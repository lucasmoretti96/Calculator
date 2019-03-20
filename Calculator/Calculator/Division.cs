using System;

namespace Calculator
{
    class Division : IOperation
    {
        public const int ERROR = -1;
        private double result;

        public double HandleOperation(double number1, double number2)
        {
            HandleDivisionByZero(number2);
            result = number1 / number2;
            return result;
        }

        public double HandleDivisionByZero(double number2)
        {
            if (number2 == 0)
            {
                Console.WriteLine("Erro, não é possível dividir por 0!");
                Console.ReadKey();
                Environment.Exit(ERROR);
            }
            return number2;
        }
    }
}
