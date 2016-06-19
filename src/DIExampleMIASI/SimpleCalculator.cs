using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIExampleMIASI
{
    public class SimpleCalculator
    {
        //private readonly List<IMathOperation> _mathOperations;

        public IEnumerable<IMathOperation> MathOperations { get; set; }


        public decimal Compute(decimal number1, decimal number2, string operationSign)
        {
            var currentMathOperation = MathOperations.Single(mathOperation => mathOperation.OperationSign() == operationSign);

            return currentMathOperation.Compute(number1, number2);
        }
    }
}
