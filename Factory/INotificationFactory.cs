using FactoryPatternWebApi.Services;
using static FactoryPatternWebApi.Enums;

namespace FactoryPatternWebApi.Factory
{
    // It's a contract that defines a method for retrieving an appropriate notification service (like email or SMS)
    public interface INotificationFactory
    {
        INotificationService GetNotificationService(NotificationType type);
    }
}
