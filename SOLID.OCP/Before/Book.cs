namespace SOLID.OCP.Before;

public class Book
{
    public static void Review(string bookName, int pages, int score, TypeBook typeBook)
    {
        if (string.IsNullOrEmpty(bookName))
        {
            // return error of validation
        }

        if (pages <= 0 || score <= 0)
        {
           // return error of validation
        }

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
