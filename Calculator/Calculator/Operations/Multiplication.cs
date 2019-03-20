namespace Calculator
{
    public class Multiplication : IOperation
    {
        public double HandleOperation(NumbersCollector numbersCollector)
            => numbersCollector.Number1 * numbersCollector.Number2;
    }
}
