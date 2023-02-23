namespace SOLID.ISP.After;
public class JuridicalPersonRepository : IJuridicalPersonRepository
{
    public DateTime GetBirthDateJuridicalPersonByName(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentNullException(nameof(name));
        }

        return DateTime.UtcNow;
    }
}
