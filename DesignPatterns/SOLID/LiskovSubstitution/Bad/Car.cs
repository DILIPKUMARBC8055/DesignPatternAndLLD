namespace DesignPatterns.SOLID.LiskovSubstitution.Bad
{
    public class Car : Vehicle
    {
        public override int getWheels()
        {
            return 4;
        }
    }
}
