using SOLID.DIP.Before.Models;
using SOLID.DIP.Before.Repositories;
namespace SOLID.DIP.Before.Services
{
    public class ClientService
    {
        public async Task AddClient(Client client)
        {
            ClientValidation(client);

            var clientRepository = new ClientRepository();

            await clientRepository.AddClient(client);

            if (client.Email is null)
            {
                throw new ArgumentNullException(nameof(client.Email));
            }

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
}