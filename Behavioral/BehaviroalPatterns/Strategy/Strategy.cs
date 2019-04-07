namespace BehavioralPatterns.Strategy
{
    using System.ComponentModel;

    public class Strategy
    {
        public enum LoggingConfiguration
        {
            File = 0,
            Database = 1,
            ApplicationInsights = 2
        };

        private readonly ILogger logger;

        public Strategy(LoggingConfiguration config)
        {
            switch (config)
            {
                case LoggingConfiguration.File:
                    logger = new FileLogger();
                    break;
                case LoggingConfiguration.Database:
                    logger = new DatabaseLogger();
                    break;
                case LoggingConfiguration.ApplicationInsights:
                    logger = new ApplicationInsightsLogger();
                    break;
                default:
                    throw new InvalidEnumArgumentException();
            }
        }

        public string LogMessage(string message) => logger.Log(message);
    }
}
