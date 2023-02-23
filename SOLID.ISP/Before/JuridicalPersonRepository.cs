namespace SOLID.ISP.Before;
public class JuridicalPersonRepository : IPersonRepository
{
    public DateTime GetBirthDateByName(string name)
    {
        // Get date specific person
        return DateTime.UtcNow;
    }

    public void Walk()
    {
        // Violating principle, here I'm forced to implement this method that not do part of juridical person
        throw new NotImplementedException("This method doesn't to a juridical person!");
    }
}