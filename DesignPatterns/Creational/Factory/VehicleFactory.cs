namespace DesignPatterns.Creational.Factory
{
    //with this we are making loose couple where client doesn't need to worry of 
    //implementing new vechile if any new thing exist vehicle factory is been used and modified
    public class VehicleFactory
    {
        private IVehicle vehicle;
        public IVehicle GetVehicle(string name)
        {
            if (name == "car")
            {
                vehicle = new Car();

            }
            else if (name == "bike")
            {
                vehicle = new Bike();

            }
            else if (name == "bus")
            {
                vehicle = new Bus();
            }
            return vehicle;
        }
    }
}
