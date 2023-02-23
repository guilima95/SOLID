using SOLID.DIP.After.Models;

namespace SOLID.DIP.After.Interfaces;
public interface IClientService
{
    Task RegisterClientAsync(Client client);
}
