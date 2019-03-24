namespace StructuralPatterns.Decorator
{
    public class PortableLaptopDecorator : ILaptop
    {
        private readonly ILaptop iLaptop;
        public PortableLaptopDecorator(ILaptop iLaptop)
        {
            this.iLaptop = iLaptop;
        }

        public int Cost => iLaptop.Cost - 5000;

        public int HardDisk => iLaptop.HardDisk;

        public int Ram => iLaptop.Ram / 2;

        public int Gpu => iLaptop.Gpu;
    }
}
