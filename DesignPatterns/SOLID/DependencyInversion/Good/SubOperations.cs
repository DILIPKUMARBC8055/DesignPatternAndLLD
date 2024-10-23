namespace DesignPatterns.SOLID.DependencyInversion.Good
{
    internal class SubOperations : ICalculatorOperation
    {
        public void calculate(int a, int b)
        {
            Console.WriteLine(a - b);
        }
    }
}
