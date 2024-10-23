namespace DesignPatterns.SOLID.DependencyInversion.Good
{
    internal class Calculator
    {
        /**
* As per DIP rule it states :
* High-level modules should not depend on low-level modules. Both should depend on abstractions.
* --- So low level is depdendent via ICalculatorOperation rather being depend on add or substract operations.
* Abstractions should not depend on details. Details should depend on abstractions
* ---Abstraction is achieved as via interface we are entering in low level.
*/
        public void calculate(int a, int b, ICalculatorOperation operation)
        {
            operation.calculate(a, b);
        }
    }
}
