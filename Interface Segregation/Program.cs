public interface IEmailService
{
    void SendEmail(string emailAddress, string message);
}

public class EmailService : IEmailService
{
    public void SendEmail(string emailAddress, string message)
    {
        Console.WriteLine($"Sending email to: {emailAddress}");
        Console.WriteLine($"Message: {message}");
    }
}

public class NotificationService
{
    private readonly IEmailService emailService;

    public NotificationService(IEmailService emailService)
    {
        this.emailService = emailService;
    }

    public void SendEmail(string emailAddress, string message)
    {
        emailService.SendEmail(emailAddress, message);
    }
}