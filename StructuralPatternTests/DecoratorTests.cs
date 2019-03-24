namespace StructuralPatternTests
{
    using StructuralPatterns.Decorator;
    using Xunit;

    public class DecoratorTests
    {
        [Fact]
        public void ShouldReturnBasicLaptop()
        {
            ILaptop laptop = new BasicLaptop();
            Assert.Equal(30000, laptop.Cost);
            Assert.Equal(8, laptop.Ram);
            Assert.Equal(250, laptop.HardDisk);
            Assert.Equal(0, laptop.Gpu);
        }

        [Fact]
        public void ShouldReturnGamingLaptop()
        {
            ILaptop laptop = new GamingLaptopDecorator(new BasicLaptop());
            Assert.Equal(60000, laptop.Cost);
            Assert.Equal(16, laptop.Ram);
            Assert.Equal(1000, laptop.HardDisk);
            Assert.Equal(2, laptop.Gpu);
        }

        [Fact]
        public void ShouldReturnPortableLaptop()
        {
            ILaptop laptop = new PortableLaptopDecorator(new BasicLaptop());
            Assert.Equal(25000, laptop.Cost);
            Assert.Equal(4, laptop.Ram);
            Assert.Equal(250, laptop.HardDisk);
            Assert.Equal(0, laptop.Gpu);
        }
    }
}
