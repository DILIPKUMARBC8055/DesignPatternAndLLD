namespace DesignPatterns.SOLID.InterfaceSegregation.good
{
    internal class FileImplementation : IOperations, FileConnections
    {
        public void createRecord()
        {
            Console.WriteLine("perform create record actions");
        }

        public void deleteRecord()
        {
            Console.WriteLine("perform delete record actions");
        }

        public void openFile()
        {
            Console.WriteLine("perform open file actions");
        }
    }
}
