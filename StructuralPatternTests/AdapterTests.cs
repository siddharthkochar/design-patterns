namespace StructuralPatternTests
{
    using StructuralPatterns.Adapter;
    using Xunit;

    public class AdapterTests
    {
        [Fact]
        public void ShouldReturnIWeatherFromGoogleWeather()
        {
            IWeather weather = new GoogleWeatherAdapter(new GoogleWeather());
            Assert.Equal(32, weather.GetTemprature(411058));
        }

        [Fact]
        public void ShouldReturnIWeatherFromAccuWeather()
        {
            IWeather weather = new AccuWeatherAdapter(new AccuWeather());
            Assert.Equal(30, weather.GetTemprature(411058));
        }
    }
}
