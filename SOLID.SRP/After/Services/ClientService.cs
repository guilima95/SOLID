using SOLID.SRP.After.Models;
using SOLID.SRP.After.Repositories;

namespace SOLID.SRP.After.Services;
public class ClientService
{
    public void AddClient(Client client)
    {
        ClientValidation(client);

        var clientRepository = new ClientRepository();

        ClientRepository.AddClient(client);

        SendEmail("xpto@company.com",
            client.Email.Address, "Welcome to",
            "Congratulations! You are registered.");
    }

    private static void SendEmail(string send, string receiver, string subject, string body)
    {
        EmailService.Send(send, receiver, subject, body);
    }

    private static void ClientValidation(Client client)
    {
        if (!client.IsValid())
        {
            throw new Exception("Client is invalid.");
        }
    }
}
