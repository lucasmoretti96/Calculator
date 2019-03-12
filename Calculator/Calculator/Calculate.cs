using System;

namespace Calculator
{
    public class Calculate
    {
        public const int ERROR = -1;

        public double HandleCalculate(double number1, double number2, string @operator)
        {
            double result = 0;
            switch (@operator)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    var number2Verified = new DivisionAccount().HandleDivisionByZero(number2);
                    result = number1 / number2Verified;
                    break;
                default:
                    Console.WriteLine("Operação não reconhecida!");
                    Console.ReadKey();
                    Environment.Exit(ERROR);
                    break;
            }
            return result;
        }
    }
}
