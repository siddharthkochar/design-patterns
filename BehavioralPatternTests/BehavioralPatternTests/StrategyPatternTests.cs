namespace BehavioralPatternTests
{
    using BehavioralPatterns.Strategy;
    using Xunit;

    public class StrategyPatternTests
    {
        [Fact]
        public void ShouldLogMessage()
        {
            var strategy = new Strategy(Strategy.LoggingConfiguration.File);
            Assert.Equal(strategy.LogMessage("file created"), 
                new FileLogger().Log("file created"));

            strategy = new Strategy(Strategy.LoggingConfiguration.Database);
            Assert.Equal(strategy.LogMessage("insert into database"),
                new DatabaseLogger().Log("insert into database"));

            strategy = new Strategy(Strategy.LoggingConfiguration.ApplicationInsights);
            Assert.Equal(strategy.LogMessage("added telemetry"),
                new ApplicationInsightsLogger().Log("added telemetry"));
        }
    }
}
