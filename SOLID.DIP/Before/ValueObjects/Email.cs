namespace SOLID.DIP.Before.ValueObjects;
public class Email
{
    public string Address { get; set; } = null!;

    public bool Valid()
    {
        return Address.Contains('@');
    }
}
