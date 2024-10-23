namespace DesignPatterns.SOLID.LiskovSubstitution.Bad
{
    public class Vehicle
    {
        public virtual int getWheels()
        {
            return 2;
        }
        public virtual bool hasEngine()
        {
            return true;
        }
    }

}
