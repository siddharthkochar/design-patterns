namespace StructuralPatterns.Facade
{
    public interface IEmailProvider
    {
        bool Send(string message, string emailAddress);
    }

    public interface IMessageProvider
    {
        bool Send(string message, string username);
    }

    public interface INotification
    {
        bool Notify(string message, string address);
    }
}
