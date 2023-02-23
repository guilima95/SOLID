using SOLID.DIP.After.Models;

namespace SOLID.DIP.After.Interfaces;
public interface IClientRepository
{
    Task AddClientAsync(Client client);
}
