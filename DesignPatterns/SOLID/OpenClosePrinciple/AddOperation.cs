namespace DesignPatterns.SOLID.OpenClosePrinciple
{
    public class AddOperation : IOperation
    {
        public decimal peform(decimal a, decimal b)
        {
            return a + b;
        }
    }
}
