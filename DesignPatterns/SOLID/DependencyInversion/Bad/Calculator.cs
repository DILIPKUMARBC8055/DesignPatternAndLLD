using DesignPatterns.SOLID.OpenClosePrinciple;
using System.Data;
using System.IO;
using System.Reflection.Emit;
using System.Reflection;

namespace DesignPatterns.SOLID.DependencyInversion.Bad
{
    internal class Calculator
    {
        //High-level modules should not depend on low-level modules.Both should depend on abstractions.
        //* --- So above rule is broken our calculator class is directly dependent on low level class.
        //* Abstractions should not depend on details.Details should depend on abstractions
        //* --- Also is dependent on actual class.
        public void calculate(int a, int b, string str)
        {
            switch (str)
            {
                case "add":
                    AddOperation add = new AddOperation();
                    add.calculate(a, b);
                    break;
                case "sub":
                    SubOperation sub = new SubOperation();
                    sub.calculate(a, b);
                    break;
                default:
                    break;
            }
        }
    }
}
