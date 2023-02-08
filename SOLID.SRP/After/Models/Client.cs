using SOLID.SRP.After.ValueObjects;

namespace SOLID.SRP.After.Models;
public class Client
{
    public Guid Id { get; }
    public string Name { get; set; } = null!;
    public Email Email { get; set; } = null!;
    public DateTime Date { get; set; }

    public bool IsValid()
    {
        return Email.Valid();
    }
}
