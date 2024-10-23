namespace DesignPatterns.SOLID.LiskovSubstitution.Bad
{
    public class Bicycle : Vehicle
    {
        public override bool hasEngine()
        {
            throw new NotImplementedException();
        }
    }
}
