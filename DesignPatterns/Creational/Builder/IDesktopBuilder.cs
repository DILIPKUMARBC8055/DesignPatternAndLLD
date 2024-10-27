namespace DesignPatterns.Creational.Builder
{
    //Builder Interface: Defines the steps required to create a product
    //(e.g., IDesktopBuilder interface).
    public interface IDesktopBuilder
    {
        IDesktopBuilder SetCPU(string cpu);
        IDesktopBuilder SetRAM(string ram);
        IDesktopBuilder SetGraphicsCard(string graphicsCard);
        IDesktopBuilder SetStorage(string storage);
        IDesktopBuilder SetPowerSupply(string powerSupply);
        IDesktopBuilder SetMotherboard(string motherboard);
        Desktop Build();
    }
}
