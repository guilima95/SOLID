namespace SOLID.DIP.After.ValueObjects;
public class Email
{
    public string Address { get; set; } = null!;

    public bool Valid()
    {
        return Address.Contains('@');
    }
}
