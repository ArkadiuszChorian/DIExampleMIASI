using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIExampleMIASI
{
    public interface IMathOperation
    {
        decimal Compute(decimal number1, decimal number2);
        string OperationSign();
    }
}
