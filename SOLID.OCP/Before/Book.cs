namespace SOLID.OCP.Before;

public class Book
{
    public void Review(string bookName, int pages, TypeBook typeBook)
    {
        if (typeBook is TypeBook.Digital)
        {
            // to do
        }

        if (typeBook is TypeBook.Physical)
        {
            // to do
        }
    }
}
