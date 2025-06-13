using FactoryPatternWebApi.Factory;
using FactoryPatternWebApi.Services;
using static FactoryPatternWebApi.Enums;

var builder = WebApplication.CreateBuilder(args);

// Register services and factory
// use transient because we don't have to worry about data sharing or concurrency issues
// since we are using service statelessness is 
builder.Services.AddTransient<EmailNotificationService>();
builder.Services.AddTransient<SmsNotificationService>();
builder.Services.AddSingleton<INotificationFactory, NotificationFactory>();

var app = builder.Build();

app.MapPost("/factory", (NotificationType type, string to, string message, INotificationFactory factory) =>
{
    var notifier = factory.GetNotificationService(type);
    notifier.Send(to, message);
    return Results.Ok($"Notification sent using {notifier}");
});

app.Run();
