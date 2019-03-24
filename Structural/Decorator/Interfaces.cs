namespace StructuralPatterns.Decorator
{
    public interface ILaptop
    {
        int Cost { get; }
        int HardDisk { get; }
        int Ram { get; }
        int Gpu { get; }
    }
}
