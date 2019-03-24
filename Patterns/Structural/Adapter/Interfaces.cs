namespace StructuralPatterns.Adapter
{
    public interface IWeather
    {
        int GetTemprature(int pincode);
    }

    public interface IAccuWeather
    {
        int GetTemprature(int pincode);
    }

    public interface IGoogleWeather
    {
        int GetCurrentTemprature(int pincode);
    }
}
