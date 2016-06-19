using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIExampleMIASI
{
    public class SubstractOperation : IMathOperation
    {
        public decimal Compute(decimal number1, decimal number2)
        {
            return number1 - number2;
        }

        public string OperationSign() => "-";
    }
}
