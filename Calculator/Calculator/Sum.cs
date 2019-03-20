namespace Calculator
{
    public class Sum : IOperation
    {
        private double result;

        public double HandleOperation(double number1, double number2)
        {
            result = number1 + number2;
            return result;
        }
    }
}
