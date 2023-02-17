namespace SOLID.LSP.After;
public class XptoClient : Client
{
    public XptoClient(string? name, DateOnly date, TypeClient type) : base(name, date, type)
    {
    }

    public Guid XptoClientId { get; set; }

    public override decimal CalculateDiscount(decimal value)
    {
        return base.CalculateDiscount(value);
    }
    public override bool IsClientSpecial()
    {
        return base.IsClientSpecial();
    }
}
