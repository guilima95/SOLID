namespace SOLID.ISP.Before;
public class PhysicalPersonRepository : IPersonRepository
{
    public DateTime GetBirthDateByName(string name)
    {
        // Get date specific person
        return DateTime.UtcNow;
    }

    public void Walk()
    {
        // Implement method walk
    }
}


public class Person
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime Birthdate { get; set; }
}