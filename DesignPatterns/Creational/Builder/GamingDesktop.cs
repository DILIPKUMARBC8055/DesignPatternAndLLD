namespace DesignPatterns.Creational.Builder
{
    //Concrete Builder: Implements the Builder interface and provides the implementation
    //for building the parts
    //(e.g., GamingDesktopBuilder, OfficeDesktopBuilder).
    public class GamingDesktop : IDesktopBuilder
    {
        private readonly Desktop _builder;
        public GamingDesktop()
        {
            _builder = new Desktop();
        }
        public Desktop Build()
        {
            return _builder;

        }

        public IDesktopBuilder SetCPU(string cpu)
        {
            _builder.CPU = cpu;
            return this;
        }

        public IDesktopBuilder SetGraphicsCard(string graphicsCard)
        {
            _builder.GraphicsCard = graphicsCard;
            return this;
        }

        public IDesktopBuilder SetMotherboard(string motherboard)
        {
            _builder.Motherboard = motherboard;
            return this;
        }

        public IDesktopBuilder SetPowerSupply(string powerSupply)
        {
            _builder.PowerSupply = powerSupply;
            return this;
        }

        public IDesktopBuilder SetRAM(string ram)
        {
            _builder.RAM = ram;
            return this;
        }

        public IDesktopBuilder SetStorage(string storage)
        {
            _builder.Storage = storage;
            return this;
        }
    }
}
