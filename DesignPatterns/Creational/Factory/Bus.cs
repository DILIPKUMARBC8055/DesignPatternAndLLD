namespace DesignPatterns.Creational.Factory
{
    public class Bus : IVehicle
    {
        public void create()
        {
            Console.WriteLine("Bus is been created");
        }
    }
}
