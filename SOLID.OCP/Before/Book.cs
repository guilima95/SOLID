namespace SOLID.OCP.Before;

public class Book
{
    public void Review(string bookName, int pages, int score, TypeBook typeBook)
    {
        if (typeBook is TypeBook.Digital)
        {
            // to do review based on score
        }

        if (typeBook is TypeBook.Physical)
        {
            // to do review based on score
        }
    }
}
