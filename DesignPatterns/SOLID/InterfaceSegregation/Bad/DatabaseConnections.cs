namespace DesignPatterns.SOLID.InterfaceSegregation.Bad
{
    public class DatabaseConnections : IBadDAO
    {
        public void createRecord()
        {
            Console.WriteLine("perform create record actions");
        }

        public void deleteRecord()
        {
            Console.WriteLine("perform delete record actions");
        }

        public void openConnection()
        {
            Console.WriteLine("perform open connections actions");
        }

        public void openFile()
        {
            //we can't open with this so exception is thrown
            throw new NotImplementedException();
        }
    }
}
