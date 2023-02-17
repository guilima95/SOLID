using System;

namespace SOLID.LSP.Before;
public class PotentialClient : Client
{
    public PotentialClient(string? name, DateOnly date, TypeClient type) : base(name, date, type)
    {
    }

    public Guid PotentialClientId { get; set; }

    public override decimal CalculateDiscount(decimal value)
    {
        return base.CalculateDiscount(value);
    }
    public override bool IsClientSpecial()
    {
        throw new NotImplementedException("How Am I special?, if I not am a Client, I'm a just potential Client!");
    }
}


