namespace DesignPatterns.Creational.Factory
{
    public class Client
    {
        static void Main(string[] args)
        {

            IVehicle vehicle ;
            Console.WriteLine("Enter vehicle to be created :");
            string str = Console.ReadLine().ToLower();
            //This make code to get tightly coupled where it suppose any changes like if we want 
            //to get new vehilce like tactor bus or other things we need to change in client code 
            //which is not good in coding 
            //so we define a factory of vechile it returns the vehicle based on the input
            //if (str == "car")
            //{
            //    vehicle = new Car();

            //}
            //else if (str == "bike")
            //{
            //    vehicle = new Bike();

            //}
            VehicleFactory vehicleFactory = new VehicleFactory();
            vehicle = vehicleFactory.GetVehicle(str);
            vehicle.create();


        }
    }
}
