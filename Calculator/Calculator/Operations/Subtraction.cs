namespace Calculator
{
    public class Subtraction : IOperation
    {
        public double HandleOperation(NumbersCollector numbersCollector)
            => numbersCollector.Number1 - numbersCollector.Number2;
    }
}