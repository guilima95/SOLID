namespace SOLID.ISP.After;
public class PhysicalPersonRepository : IPhysicalPersonRepository
{
    public DateTime GetBirthDateByName(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentNullException(nameof(name));
        }
        
        return DateTime.UtcNow;
    }

    public void Walk()
    {
        Console.WriteLine("Walking, a person can walk!");
    }
}
