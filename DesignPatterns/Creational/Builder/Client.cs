namespace DesignPatterns.Creational.Builder
{
    public class Client
    {
        public static void Main1(string[] a)
        {
            IDesktopBuilder gamingBuilder = new GamingDesktop();
            DesktopDirector director = new DesktopDirector(gamingBuilder);

            Desktop gamingDesktop = director.BuildGamingDesktop();
            Console.WriteLine("Gaming Desktop Configuration:");
           // gamingDesktop=gamingBuilder.SetRAM("255 GB").Build();
            Console.WriteLine(gamingDesktop.ToString());

            // Create a custom desktop using fluent builder pattern
            Desktop customDesktop = new GamingDesktop()
                .SetCPU("AMD Ryzen 9")
                .SetRAM("64GB DDR4")
                .SetGraphicsCard("NVIDIA RTX 4090")
                .SetStorage("2TB NVMe SSD")
                .SetPowerSupply("850W")
                .SetMotherboard("Gigabyte Aorus X570")
                .Build();

            Console.WriteLine("\nCustom Desktop Configuration:");
            Console.WriteLine(customDesktop);
        }

    }
}
