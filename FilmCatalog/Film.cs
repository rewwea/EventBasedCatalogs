public class Film
{
    public string Title { get; set; }
    public string Genre { get; set; }
    public int ReleaseYear { get; set; }
    public float Rating { get; set; }

    public Film(string title, string genre, int releaseYear, float rating)
    {
        Title = title;
        Genre = genre;
        ReleaseYear = releaseYear;
        Rating = rating;
    }

    public override string ToString()
    {
        return $"{Title} ({Genre}, {ReleaseYear}, Рейтинг: {Rating})";
    }
}