namespace DesignPatterns.SOLID.DependencyInversion.Bad
{
    internal class SubOperation
    {
        public void calculate(int a, int b)
        {
            Console.WriteLine(a - b);
        }
    }
}
