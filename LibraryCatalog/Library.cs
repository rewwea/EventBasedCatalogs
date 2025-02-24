using System;
using System.Collections.Generic;

public delegate void BookEventHandler(Book book);

public class Library
{
    private Dictionary<string, Book> books = new Dictionary<string, Book>();
    public event BookEventHandler BookAdded;
    public event BookEventHandler BookBorrowed;

    public void AddBook(Book book)
    {
        books[book.ISBN] = book;
        OnBookAdded(book);
    }

    public void BorrowBook(string isbn)
    {
        if (books.ContainsKey(isbn))
        {
            OnBookBorrowed(books[isbn]);
        }
        else
        {
            Console.WriteLine("Книга не найдена.");
        }
    }

    protected virtual void OnBookAdded(Book book)
    {
        BookAdded?.Invoke(book);
    }

    protected virtual void OnBookBorrowed(Book book)
    {
        BookBorrowed?.Invoke(book);
    }
}