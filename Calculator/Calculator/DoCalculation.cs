using Calculator.Interfaces;

namespace Calculator
{
    public class DoCalculation : IDoCalculation
    {
        private readonly IOperation _operation;

        public DoCalculation(IOperation operation)
        {
            _operation = operation;
        }

        public double Calculation(double number1, double number2)
        {
            return _operation.HandleOperation(new NumbersCollector(number1, number2));
        }
    }
}
