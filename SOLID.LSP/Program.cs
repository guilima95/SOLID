using SOLID.LSP.After;
using SOLID.LSP.Before;

Menu();

var option = Console.ReadKey();

switch (option.KeyChar)
{
    case '1':
        Console.WriteLine(" Let's go, for example, the code violing the LSP principle. When a subclass is not a class, this inheritance doesn't sense.");
        BeforeViolatingPrinciple();
        break;

    case '2':
        Console.WriteLine(" Let's go, for example, the code using the solution LSP principle with the way correctly. When a subclass is a to class, this inheritance do sense.");
        AfterCorrectlyPrinciple();
        Console.WriteLine("The LSP says that if you change the parent class to the child, nothing should change");
        break;
}

static void Menu()
{
    Console.Clear();
    Console.WriteLine("Apply discount for the client using SOLID Principle LSP:");
    Console.WriteLine("Choice a option:");
    Console.WriteLine();
    Console.WriteLine("1 - Using potencial client, violation principle LSP.");
    Console.WriteLine("2 - Using a true client existence, solution correctly LSP.");
}

Console.ReadKey();

static void BeforeViolatingPrinciple()
{
    try
    {
        PotentialClient client = new("Potencial Client", DateOnly.FromDateTime(new DateTime(2022, 11, 1)), TypeClient.Gold);

        Console.WriteLine("Checking special client/discount by date...");

        var valueDiscount = client.CalculateDiscount(100);

        string specialClient = client.IsClientSpecial() ?
            $"Nice!!! The client on date: {client.Date} is special" :
            $"Oh No!!! The client on date: {client.Date} still not is special";

        Console.WriteLine($"The client {client.Name} will pay the value of R$ {valueDiscount} with discount of {100 - valueDiscount}, {specialClient}");
    }
    catch (Exception ex)
    {
        Console.WriteLine("ATTENTION!! Oops, principle LSP was violation!");
        Console.WriteLine($"Exception: {ex.Message}");
    }

    Console.ReadKey();
}

static void AfterCorrectlyPrinciple()
{
    try
    {
        XptoClient client = new("Client Guilherme", DateOnly.FromDateTime(new DateTime(2022, 11, 1)), TypeClient.Gold);

        Console.WriteLine("Checking special client/discount by date...");

        var valueDiscount = client.CalculateDiscount(100);

        string specialClient = client.IsClientSpecial() ?
            $"the client on date: {client.Date} is special" :
            $"the client on date: {client.Date} not is special";

        Console.WriteLine($"The client {client.Name} will pay the value of R$ {valueDiscount} with discount of {100 - valueDiscount}, {specialClient}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Oops, principle LSP was violation:{ex.Message}");
    }

    Console.ReadKey();
}

public class Client
{
    protected Client(string? name, DateOnly date, TypeClient type)
    {
        Name = name;
        Date = date;
        Type = type;
    }

    public Guid Id => Guid.NewGuid();
    public string? Name { get; set; }
    public DateOnly Date { get; set; }
    public TypeClient Type { get; set; }

    public virtual decimal CalculateDiscount(decimal value)
    {
        switch (Type)
        {
            case TypeClient.Gold:
                return value * 0.40m; // 60% of discount
            case TypeClient.Silver:
                return value * 0.60m; // 40% of discount
            case TypeClient.Bronze:
                return value * 0.80m; // 20% of discount
            default:
                return value; // If you are not a client, don't has a discount!
        }
    }

    public virtual bool IsClientSpecial()
    {
        return Date.Year > 2020;
    }
}
