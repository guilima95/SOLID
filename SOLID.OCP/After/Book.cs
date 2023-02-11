namespace SOLID.OCP.After;

// Abstract class can only to be inheract
public abstract class Book
{
    public abstract string Review(int pages, string bookName, int rate);

    public static string GetReviewBook(int score)
    {
        if (score is 1)
        {
            return $"bad book, I not recommend. Score avaliation: {score}";
        }

        if (score is 2 or 3)
        {
            return $"good, but could to be best. Score avaliation: {score}";
        }

        if (score is 4 or 5)
        {
            return $"great book! I liked, very weel. Score avaliation: {score}";
        }

        return $"score avaliation not available: {score}. re-evaluate!";
    }
}
