namespace DesignPatterns.SOLID.LiskovSubstitution.Bad
{
    public class UsageClass
    {
        public void use()
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(new Car());
            vehicles.Add(new Bike());
            vehicles.Add(new Bicycle());
            foreach (Vehicle vehicle in vehicles)
            {
                //here the code will break at the run time where we have not implement 
                //hasEngine by throwing some error 
                Console.WriteLine(vehicle.hasEngine().ToString());
            }
        }
    }
}
