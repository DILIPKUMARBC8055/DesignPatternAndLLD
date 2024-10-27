namespace DesignPatterns.Creational.Factory
{
    public class Car : IVehicle
    {
        
        public void create()
        {
            Console.WriteLine("Car is been Created");
        }
    }
}
