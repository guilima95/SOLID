using SOLID.DIP.After.Interfaces;
using System.Net.Mail;

namespace SOLID.DIP.After.Services;
public class EmailService : IEmailService
{
    private const int PORT = 25;
    private const string HOST_GOOGLE = "smtp.google.com";

    public async Task SendEmailAsync(string sender, string receiver, string subject, string body)
    {
        MailMessage mail = new(sender, receiver);
        SmtpClient client = new()
        {
            Port = PORT,
            Host = HOST_GOOGLE,
            UseDefaultCredentials = false,
            DeliveryMethod = SmtpDeliveryMethod.Network
        };

        mail.Subject = subject;
        mail.Body = body;

        await Task.Run(() => client.Send(mail));
    }
}
