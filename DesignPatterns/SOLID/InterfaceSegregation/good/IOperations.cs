namespace DesignPatterns.SOLID.InterfaceSegregation.good
{
    //here we are segreating the interface where this interface only perform operating on
    //file or db other will be do file open will be related to 
    public interface IOperations
    {
        void createRecord();
        void deleteRecord();
    }
}
