namespace DesignPatterns.Creational.Builder
{
    //this is actually a product class in which actual product is been made availbe
    //Product: The complex object that is being built (e.g., Desktop class).
    public class Desktop
    {
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string GraphicsCard { get; set; }
        public string Storage { get; set; }
        public string PowerSupply { get; set; }
        public string Motherboard { get; set; }
        public override string ToString()
        {
            return $"CPU: {CPU},\n RAM: {RAM},\n GraphicsCard: {GraphicsCard},\n " +
                   $"Storage: {Storage},\n PowerSupply: {PowerSupply},\n Motherboard: {Motherboard}";
        }

    }
}
