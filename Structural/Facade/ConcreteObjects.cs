namespace StructuralPatterns.Facade
{
    public class Mandrill : IEmailProvider
    {
        public bool Send(string message, string emailAddress) =>
            !string.IsNullOrWhiteSpace(message) &&
            !string.IsNullOrWhiteSpace(emailAddress);
    }

    public class Slack : IMessageProvider
    {
        public bool Send(string message, string username) =>
            !string.IsNullOrWhiteSpace(message) &&
            !string.IsNullOrWhiteSpace(username);
    }
}
