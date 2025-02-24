public class Reader
{
    public void OnBookAdded(Book book)
    {
        Console.WriteLine($"[Читатель] Я получил уведомление о новой книге: {book.Title}");
    }

    public void OnBookBorrowed(Book book)
    {
        Console.WriteLine($"[Читатель] Я взял книгу: {book.Title}");
    }
}