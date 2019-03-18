namespace Calculator
{
    class Multiplication : ICalculate
    {
        private double result;

        public double HandleCalculate(double number1, double number2)
        {
            result = number1 * number2;
            return result;
        }
    }
}
