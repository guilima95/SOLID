using Microsoft.Data.SqlClient;
using System.Data;
using System.Net.Mail;

namespace SOLID.SRP.Before;

public class Client
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public DateTime? Date { get; set; }

    public void AddClient()
    {
        if (string.IsNullOrEmpty(Email))
        {
            throw new ArgumentNullException(nameof(Email));
        }

        if (!Email.Contains('@'))
        {
            throw new Exception("format email is incorrect.");
        }

        if (string.IsNullOrEmpty(Name))
        {
            throw new ArgumentNullException(nameof(Email));
        }

        using var connection = new SqlConnection();

        var sqlCommand = new SqlCommand();

        connection.ConnectionString = "connectionString";
        sqlCommand.Connection = connection;
        sqlCommand.CommandType = CommandType.Text;
        sqlCommand.CommandText = "INSERT INTO Client (Name, Email, Date) Values (@name, @email, @date)";

        sqlCommand.Parameters.AddWithValue("name", Name);
        sqlCommand.Parameters.AddWithValue("email", Email);
        sqlCommand.Parameters.AddWithValue("date", Date);

        connection.Open();
        sqlCommand.ExecuteNonQuery();

        var mail = new MailMessage("xpto@company.com", Email);
        var client = new SmtpClient
        {
            Port = 25,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            Host = "smtp.google.com"
        };

        mail.Subject = "Welcome to";
        mail.Body = "Congratulations! You are registered.";
        client.Send(mail);
    }
}
