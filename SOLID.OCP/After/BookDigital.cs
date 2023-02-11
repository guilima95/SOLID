namespace SOLID.OCP.After;

public class BookDigital : Book
{
    public override string Review(int pages, string bookName, int score)
    {
        return GetReviewBook(score);
    }
}
