namespace BehavioralPatterns.Strategy
{
    public class DatabaseLogger : ILogger
    {
        public string Log(string message) => $"Database logger - {message}";
    }

    public class FileLogger : ILogger
    {
        public string Log(string message) => $"File logger - {message}";
    }

    public class ApplicationInsightsLogger : ILogger
    {
        public string Log(string message) => $"AppInsights logger - {message}";
    }
}
