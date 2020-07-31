namespace Calculator
{
    public class Sum : IOperation
    {
        public double HandleOperation(NumbersCollector numbersCollector)
            => numbersCollector.Number1 + numbersCollector.Number2;
    }
}