using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    interface IOperation
    {
        double HandleOperation(double number1, double number2);
    }
}
