namespace SOLID.ISP.Before;
public interface IPersonRepository
{
    void Walk();

    DateTime GetBirthDateByName(string name);
}
