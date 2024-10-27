namespace DesignPatterns.Creational.Builder
{
    //Director: Oversees the construction process using the builder interface.
    //It decides the sequence of the building steps.
    public class DesktopDirector
    {
        private readonly IDesktopBuilder _builder;

        public DesktopDirector(IDesktopBuilder builder)
        {
            _builder = builder;
        }

        // Create a gaming desktop configuration
        public Desktop BuildGamingDesktop()
        {
            return _builder
                .SetCPU("Intel Core i9")
                .SetRAM("32GB DDR4")
                .SetGraphicsCard("NVIDIA RTX 3080")
                .SetStorage("1TB SSD")
                .SetPowerSupply("750W")
                .SetMotherboard("ASUS ROG STRIX Z490")
                .Build();
        }

        // Create an office desktop configuration
        public Desktop BuildOfficeDesktop()
        {
            return _builder
                .SetCPU("Intel Core i5")
                .SetRAM("16GB DDR4")
                .SetGraphicsCard("Integrated Graphics")
                .SetStorage("512GB SSD")
                .SetPowerSupply("500W")
                .SetMotherboard("MSI PRO Z490-A")
                .Build();
        }
    }
}
