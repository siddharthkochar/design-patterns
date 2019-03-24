namespace StructuralPatternTests
{
    using StructuralPatterns.Facade;
    using Xunit;

    public class FacadeTests
    {
        [Fact]
        public void ShouldNotifyUserByEmailAndMessage()
        {
            INotification notification = new Notification();
            Assert.True(notification.Notify("hello", "user@gmail.com"));
            Assert.False(notification.Notify(null, "user@gmail.com"));
            Assert.False(notification.Notify(null, null));
            Assert.False(notification.Notify("hello", null));
        }
    }
}
