namespace StructuralPatterns.Adapter
{
    public class AccuWeather : IAccuWeather
    {
        public int GetTemprature(int pincode) => 30;
    }

    public class GoogleWeather : IGoogleWeather
    {
        public int GetCurrentTemprature(int pincode) => 32;
    }
}
