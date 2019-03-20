namespace Calculator
{
    public interface ICalculate
    {
        double HandleCalculate(double number1, double number2);
        ICalculate GetCalculate(string @operator);
    }
}
