using System;
using System.Collections;

namespace Calculator
{
    internal class Program
    {
        public const int ERROR = -1;
        public const int OPERATOR = 0;
        public const int NUMBER_1 = 1;
        public const int NUMBER_2 = 2;

        static void Main(string[] args)
        {
            try
            {
                double number1, number2;
                var operation = new OperationCollector(args[OPERATOR]);
                number1 = Convert.ToDouble(args[NUMBER_1]);
                number2 = Convert.ToDouble(args[NUMBER_2]);
                var numbers = new NumbersCollector(number1, number2);
                var calculate = new Calculate();
                var result = calculate.HandleCalculate(numbers.Number1, numbers.Number2, operation.Operator);
                Console.WriteLine($"{numbers.Number1} {operation.Operator} {numbers.Number2} = {result}");
                Console.ReadKey();
            }
            catch (Exception alert)
            {
                Console.WriteLine("Erro ao executar o script!", alert.Message);
                Console.ReadKey();
                Environment.Exit(ERROR);
                throw;
            }
        }
    }
}
