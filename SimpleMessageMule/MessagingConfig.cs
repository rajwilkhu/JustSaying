using JustEat.Simples.NotificationStack.AwsTools;

namespace SimpleMessageMule
{
    public interface IMessagingConfig
    {
        int PublishFailureReAttempts { get; }
        int PublishFailureBackoffMilliseconds { get; }
        string Region { get; set; }
    }
    public class MessagingConfig : INotificationStackConfiguration, IMessagingConfig
    {
        public MessagingConfig()
        {
            PublishFailureReAttempts = NotificationStackConstants.DEFAULT_PUBLISHER_RETRY_COUNT;
            PublishFailureBackoffMilliseconds = NotificationStackConstants.DEFAULT_PUBLISHER_RETRY_INTERVAL;
        }

        public int PublishFailureReAttempts { get; set; }
        public int PublishFailureBackoffMilliseconds { get; set; }
        public string Region { get; set; }
    }
}