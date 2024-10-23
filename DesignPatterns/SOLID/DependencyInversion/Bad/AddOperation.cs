namespace DesignPatterns.SOLID.DependencyInversion.Bad
{
    internal class AddOperation
    {
        public void calculate(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}
