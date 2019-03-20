using System;

namespace Calculator
{
    public class Calculate : ICalculate
    {
        public const int ERROR = -1;

        public double HandleCalculate(object numbers, string @operator)
        {
            var operation = GetCalculate(@operator);

            return operation.HandleCalculate(numbers, @operator);
        }

        ICalculate ICalculate.GetCalculate(string @operator)
        {
            ICalculate calculate = null;

            switch (@operator)
            {
                case "+":
                    calculate = (ICalculate)new Sum();
                    break;
                case "-":
                    calculate = (ICalculate)new Subtraction();
                    break;
                case "*":
                    calculate = (ICalculate)new Multiplication();
                    break;
                case "/":
                    calculate = (ICalculate)new Division();
                    break;
                default:
                    Console.WriteLine("Operação não reconhecida!");
                    Console.ReadKey();
                    Environment.Exit(ERROR);
                    break;
            }

            return calculate;
        }
    }
}
