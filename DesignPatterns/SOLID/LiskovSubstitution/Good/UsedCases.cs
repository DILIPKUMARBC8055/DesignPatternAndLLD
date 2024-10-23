

using System.Collections;

namespace DesignPatterns.SOLID.LiskovSubstitution.Good
{
    //object of superclass should be replaceable with object of its subclasses without affecting the 
    //corretness of code
    public class UsedCases
    {
        public void use()
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(new Car());
            vehicles.Add(new Bike());
            vehicles.Add(new Bicycle());
            foreach (Vehicle vehicle in vehicles)
            {

                //at the time of complie time it shows error where the error at run time 
                //is avoided 
                //Console.WriteLine(vehicle.hasEngine().ToString());
            }
            //another best example is for iteration 
            IEnumerable ints = new List<int> { 1, 2, 3 };
            IEnumerable ints1 = new ArrayList { 1, 2, 3 };
            IEnumerable ints2 = new LinkedList<int>(new int[] { 1, 2, 3 });
            
            //for add and remove
            ICollection<int> col = new List<int> { 1, 2, 3 };
            col.Add(1);
            ICollection coll = new ArrayList { 1, 2, 3 };
            
            ICollection coll2 = new LinkedList<int>(new int[] { 1, 2, 3 });

            //

            


        }
    }
}
