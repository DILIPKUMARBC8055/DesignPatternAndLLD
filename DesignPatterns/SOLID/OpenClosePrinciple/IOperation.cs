namespace DesignPatterns.SOLID.OpenClosePrinciple
{
    //here we define opeation interface where it has method perfrom 
    //any operations like add sub div and multiply will inherit from this interface and implement
    //this helps in making availble to extenions (open for extension) with out modifying the classes
    public interface IOperation
    {
        decimal peform(decimal a, decimal b);
    }
}
