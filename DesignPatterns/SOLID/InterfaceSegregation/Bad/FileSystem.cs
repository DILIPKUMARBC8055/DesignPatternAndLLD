namespace DesignPatterns.SOLID.InterfaceSegregation.Bad
{
    public class FileSystem : IBadDAO
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
            //can't connect to file system so throw exceptions
            throw new NotImplementedException();
        }

        public void openFile()
        {
            Console.WriteLine("perform open file actions");
        }
    }
}
