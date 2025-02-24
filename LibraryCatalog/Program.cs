using System;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();
        Reader reader = new Reader();
        Librarian librarian = new Librarian();

        library.BookAdded += reader.OnBookAdded;
        library.BookAdded += librarian.OnBookAdded;
        library.BookBorrowed += reader.OnBookBorrowed;

        library.AddBook(new Book("1984", "Джордж Оруэлл", 1949, "978-5-17-094229-4"));
        library.BorrowBook("978-5-17-094229-4");
    }
}