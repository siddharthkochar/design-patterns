namespace StructuralPatterns.Decorator
{
    public class BasicLaptop : ILaptop
    {
        public int Cost => 30000;

        public int HardDisk => 250;

        public int Ram => 8;

        public int Gpu => 0;
    }
}
