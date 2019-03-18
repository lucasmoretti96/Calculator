using System;

namespace Calculator
{
    public class Calculate
    {
        public const int ERROR = -1;

        public double HandleCalculate(double number1, double number2, string @operator)
        {
            double result = 0;
            var sum = new Sum();
            var sub = new Subtraction();
            var mult = new Multiplication();
            var div = new Division();
            var divAccount = new DivisionAccount();
            switch (@operator)
            {
                case "+":
                    result = sum.HandleCalculate(number1, number2);
                    break;
                case "-":
                    result = sub.HandleCalculate(number1, number2);
                    break;
                case "*":
                    result = mult.HandleCalculate(number1, number2);
                    break;
                case "/":
                    var number2Verified = divAccount.HandleDivisionByZero(number2);
                    result = div.HandleCalculate(number1, number2Verified);
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
