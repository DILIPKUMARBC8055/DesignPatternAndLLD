using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID.DependencyInversion.Good
{
    public class AddOperation : ICalculatorOperation
    {
        public void calculate(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}
