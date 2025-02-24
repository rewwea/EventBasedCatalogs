public class Librarian
{
    public void OnBookAdded(Book book)
    {
        Console.WriteLine($"[Библиотекарь] Книга \"{book.Title}\" успешно добавлена в библиотеку.");
    }
}