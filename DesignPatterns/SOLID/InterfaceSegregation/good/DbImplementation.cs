namespace DesignPatterns.SOLID.InterfaceSegregation.good
{
    
    public class DbImplementation : IOperations, IDbConnections
    {
        public void createConnections()
        {
            Console.WriteLine("perform create connections to db actions");
        }

        public void createRecord()
        {
            Console.WriteLine("perform create record actions");
        }

        public void deleteRecord()
        {
            Console.WriteLine("perform delete record actions");
        }
    }
}
