using System.Net.Mail;

namespace SOLID.DIP.Before.Services;
public class EmailService
{
    private const int PORT = 25;
    private const string HOST_GOOGLE = "smtp.google.com";

    public static void Send(string sender, string receiver, string subject, string body)
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

        client.Send(mail);
    }
}
