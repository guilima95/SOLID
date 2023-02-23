using SOLID.DIP.After.Interfaces;
using SOLID.DIP.After.Models;

namespace SOLID.DIP.After.Services;
public class ClientService : IClientService
{
    private readonly IClientRepository _clientRepository;

    public ClientService(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    public async Task RegisterClientAsync(Client client)
    {
        if (!client.IsValid())
        {
            throw new Exception("client is not valid!");
        }

        await _clientRepository.AddClientAsync(client);
    }
}
