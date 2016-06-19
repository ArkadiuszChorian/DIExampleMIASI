using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIExampleMIASI
{
    public class SimpleCalculator
    {
        private readonly List<IMathOperation> _mathOperations;

        public SimpleCalculator(List<IMathOperation> mathOperations)
        {
            _mathOperations = mathOperations;
        }

        public decimal Compute(decimal number1, decimal number2)
        {
            return _mathOperation.Compute(number1, number2);
        }
    }
}
