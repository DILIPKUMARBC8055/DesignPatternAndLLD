namespace DesignPatterns.SOLID.LiskovSubstitution.Good
{
    public class Car : Vehicle
    {
        public override int getWheels()
        {
            return 4;
        }
    }
}
