namespace FactoryPatternWebApi.Services
{
    public class EmailNotificationService : INotificationService
    {
        public void Send(string to, string message)
        {
            Console.WriteLine($"Email sent to {to}: {message}");
        }
    }
}
