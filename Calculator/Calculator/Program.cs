﻿using System;

namespace Calculator
{
    internal class Program
    {
        public const int ERROR = -1;
        public const int OPERATOR = 0;
        public const int NUMBER_1 = 1;
        public const int NUMBER_2 = 2;

        private static void Main(string[] args)
        {
            try
            {
                double number1, number2;
                var operation = new OperationCollector(args[OPERATOR]);

                number1 = Convert.ToDouble(args[NUMBER_1]);
                number2 = Convert.ToDouble(args[NUMBER_2]);
                var numbers = new NumbersCollector(number1, number2);

                var InterfaceWithTypeOfCalculation = new FactoryCalculationType(operation.Operator);

                var fazCalculo = new DoCalculation(InterfaceWithTypeOfCalculation.GetOperation());

                var result = fazCalculo.Calculation(number1, number2);

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