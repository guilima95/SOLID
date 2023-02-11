namespace SOLID.OCP.After;

public class BookPhysical : Book
{
    public override string Review(int pages, string bookName, int score)
    {
        return GetReviewBook(score);
    }
}
