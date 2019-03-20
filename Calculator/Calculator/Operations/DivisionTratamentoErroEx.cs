using System;

namespace Calculator
{
    public static class DivisionTratamentoErroEx
    {
        public const int ERROR = -1;

        public static double Tratar(this Division division, double number2)
        {
            if (number2 == 0)
            {
                Console.WriteLine("Erro, não é possível dividir por 0!");
                Console.ReadKey();
                Environment.Exit(ERROR);
            }
            return number2;
        }
    }
}
