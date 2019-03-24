namespace StructuralPatterns.Decorator
{
    public class GamingLaptopDecorator : ILaptop
    {
        private readonly ILaptop iLaptop;
        public GamingLaptopDecorator(ILaptop iLaptop)
        {
            this.iLaptop = iLaptop;
        }

        public int Cost => iLaptop.Cost * 2;

        public int HardDisk => iLaptop.HardDisk * 4;

        public int Ram => iLaptop.Ram * 2;

        public int Gpu => 2;
    }
}
