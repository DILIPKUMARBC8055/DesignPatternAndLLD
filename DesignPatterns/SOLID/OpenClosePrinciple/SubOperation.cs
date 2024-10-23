namespace DesignPatterns.SOLID.OpenClosePrinciple
{
    public class SubOperation : IOperation
    {
        public decimal peform(decimal a, decimal b)
        {
            return a - b;
        }
    }
}
