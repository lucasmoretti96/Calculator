using System;

namespace Calculator
{
    public class FactoryCalculationType : ICalculationType
    {
        public const int ERROR = -1;

        public FactoryCalculationType(string typeOperation)
        {
            TypeOperation = typeOperation;
        }

        public string TypeOperation { get; }

        public IOperation GetOperation()
        {
            IOperation operation = null;

            switch (TypeOperation)
            {
                case "+":
                    operation = new Sum();
                    break;
                case "-":
                    operation = new Subtraction();
                    break;
                case "*":
                    operation = new Multiplication();
                    break;
                case "/":
                    operation = new Division();
                    break;
                default:
                    Console.WriteLine("Operação não reconhecida!");
                    Console.ReadKey();
                    Environment.Exit(ERROR);
                    break;
            }
            return operation;
        }
    }
}
