using FactoryPatternWebApi.Services;
using static FactoryPatternWebApi.Enums;

namespace FactoryPatternWebApi.Factory
{
    public class NotificationFactory : INotificationFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public NotificationFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        // based on the type, provide service sms or email
        public INotificationService GetNotificationService(NotificationType type)
        {
            return type switch
            {
                NotificationType.Email => _serviceProvider.GetRequiredService<EmailNotificationService>(),
                NotificationType.Sms => _serviceProvider.GetRequiredService<SmsNotificationService>(),
                _ => _serviceProvider.GetRequiredService<SmsNotificationService>()
            };
        }
    }
}

