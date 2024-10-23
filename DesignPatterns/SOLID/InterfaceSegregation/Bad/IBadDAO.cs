namespace DesignPatterns.SOLID.InterfaceSegregation.Bad
{
    public interface IBadDAO
    {
        void openConnection();
        void openFile();
        void createRecord();
        void deleteRecord();

    }
}
