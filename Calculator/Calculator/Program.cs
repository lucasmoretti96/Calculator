using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        public const int ERROR = -1;

        static void Main(string[] args)
        {
            try
            {
                string asnwer;
                do
                {
                    string operation;
                    double result = 0;
                    double number1, number2;
                    Console.Write("Escolha a operação a ser executada(+, -, *, /): ");
                    operation = Console.ReadLine();
                    Console.Write("Informe o primeiro número: ");
                    number1 = double.Parse(Console.ReadLine());
                    Console.Write("Informe o segundo número: ");
                    number2 = double.Parse(Console.ReadLine());
                    switch (operation)
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
                            if (number2 == 0)
                            {
                                Console.WriteLine("Erro, não é possível dividir por 0!");
                                Console.ReadKey();
                                Environment.Exit(ERROR);
                                break;
                            }
                            result = number1 / number2;
                            break;
                        default:
                            Console.WriteLine("Operação não reconhecida!");
                            Console.ReadKey();
                            Environment.Exit(ERROR);
                            break;
                    }
                    Console.WriteLine($"{number1} {operation} {number2} = {result}");
                    Console.ReadKey();
                    Console.WriteLine("Deseja realizar outra operação? (S - Sim / N - Não)");
                    asnwer = Console.ReadLine();
                } while (asnwer.Equals("S") || asnwer.Equals("s"));
            }
            catch (Exception alert)
            {
                Console.WriteLine("Erro ao executar o script!", alert.Message);
                Console.ReadKey();
                Environment.Exit(ERROR);
                throw;
            }
        }
    }
}
