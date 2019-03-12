using System;

namespace Calculator
{
    internal class DivisionAccount
    {
        public const int ERROR = -1;

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
