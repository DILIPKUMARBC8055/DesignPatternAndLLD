namespace DesignPatterns.SOLID.OpenClosePrinciple
{
    public class BadCalculator
    {
        //this is the example where it is not close to modification 
        //virtual is not there where any changes you want to make we need to come here and update things
        //which is not good so once class is create we need to create in such a way that is should not be
        // modified and it should be able to open to extends to the other features
        public decimal perform(decimal a, decimal b, string str)
        {
            switch (str)
            {
                case "add":
                    return a + b;
                case "sub":
                    return a - b;
                default:
                    return a;

            }
           
        }
    }
}
