namespace FactoryPatternWebApi.Services
{
    public interface INotificationService
    {
        void Send(string to, string message);
    }
}
