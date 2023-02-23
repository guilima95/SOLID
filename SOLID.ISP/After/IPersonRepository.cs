namespace SOLID.ISP.After;
public interface IPersonRepository
{
    void Walk();

    DateTime GetBirthDateByName(string name);

}
