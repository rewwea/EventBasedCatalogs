public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int YearPublished { get; set; }
    public string ISBN { get; set; }

    public Book(string title, string author, int yearPublished, string isbn)
    {
        Title = title;
        Author = author;
        YearPublished = yearPublished;
        ISBN = isbn;
    }

    public override string ToString()
    {
        return $"{Title} ({Author}, {YearPublished}, ISBN: {ISBN})";
    }
}