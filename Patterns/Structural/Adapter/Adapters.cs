namespace StructuralPatterns.Adapter
{
    public class AccuWeatherAdapter : IWeather
    {
        private readonly IAccuWeather iAccuWeather;

        public AccuWeatherAdapter(IAccuWeather iAccuWeather)
        {
            this.iAccuWeather = iAccuWeather;
        }

        public int GetTemprature(int pincode) => iAccuWeather.GetTemprature(pincode);
    }

    public class GoogleWeatherAdapter : IWeather
    {
        private readonly IGoogleWeather iGoogleWeather;

        public GoogleWeatherAdapter(IGoogleWeather iGoogleWeather)
        {
            this.iGoogleWeather = iGoogleWeather;
        }

        public int GetTemprature(int pincode) => iGoogleWeather.GetCurrentTemprature(pincode);
    }
}
