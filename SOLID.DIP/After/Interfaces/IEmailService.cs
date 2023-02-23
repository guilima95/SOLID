using SOLID.DIP.After.Models;

namespace SOLID.DIP.After.Interfaces;

public interface IEmailService
{
    Task SendEmailAsync(string sender, string receiver, string subject, string body);
}