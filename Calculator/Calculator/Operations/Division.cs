namespace Calculator
{
    public class Division : IOperation
    {
        public const int ERROR = -1;
        public double number1 = 0;
        public double number2 = 0;


        public double HandleOperation(NumbersCollector numbersCollector)
        {
            number2 = this.Tratar(number2);
            number1 = numbersCollector.Number1;
            return number1 / number2;
        }
    }
}
