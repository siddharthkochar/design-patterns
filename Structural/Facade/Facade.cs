namespace StructuralPatterns.Facade
{
    public class Notification : INotification
    {
        private readonly IMessageProvider messageProvider;
        private readonly IEmailProvider emailProvider;

        public Notification()
        {
            messageProvider = new Slack();
            emailProvider = new Mandrill();
        }

        public bool Notify(string message, string address)
        {
            bool isMessageSent = messageProvider.Send(message, address);
            bool isEmailSent = emailProvider.Send(message, address);
            return isMessageSent && isEmailSent;
        }
    }
}
