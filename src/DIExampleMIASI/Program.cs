using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Threading.Tasks;
using Autofac;

namespace DIExampleMIASI
{
    public class Program
    {       
        public static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<AddOperation>().Named<IMathOperation>("+");
            builder.RegisterType<SimpleCalculator>();
            var diContainer = builder.Build();

            var simpleCalculator = diContainer.Resolve<SimpleCalculator>();

            decimal number1=1, number2=4;
            Console.WriteLine("Podaj dwie liczby");
            //number1 = Console.Read();
            Console.WriteLine("xx");
            //number2 = Console.Read();
            
            Console.WriteLine("aa");
            Console.WriteLine(simpleCalculator.Compute(number1, number2));
            Console.Read();
        }
    }
}
