namespace DesignPatterns.SOLID.OpenClosePrinciple
{
    public class Calculator
    {
        public void calculate(decimal a, decimal b, IOperation operation)
        {
            Console.WriteLine(operation.peform(a, b));
        }
    }
}
