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
            builder.RegisterType<AddOperation>().As<IMathOperation>();
            builder.RegisterType<SubstractOperation>().As<IMathOperation>();
            builder.RegisterType<SimpleCalculator>();
            var diContainer = builder.Build();

            var simpleCalculator = diContainer.Resolve<SimpleCalculator>();
            simpleCalculator.MathOperations = diContainer.Resolve<IEnumerable<IMathOperation>>();

            decimal number1, number2;
            Console.WriteLine("Podaj pierwsza liczbe");
            number1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Podaj znak dzialania");
            var operationSign = Console.ReadLine();
            Console.WriteLine("Podaj druga liczbe");
            number2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Wynik");
            Console.WriteLine(simpleCalculator.Compute(number1, number2, operationSign));
            Console.Read();
        }
    }
}
