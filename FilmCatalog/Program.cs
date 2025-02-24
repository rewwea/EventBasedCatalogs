using System;

class Program
{
    static void Main(string[] args)
    {
        FilmCatalog catalog = new FilmCatalog();
        User user = new User();
        Critic critic = new Critic();

        catalog.FilmAdded += user.OnFilmAdded;
        catalog.FilmAdded += critic.OnFilmAdded;

        catalog.AddFilm(new Film("Интерстеллар", "Научная фантастика", 2014, 8.6f));
        catalog.AddFilm(new Film("Матрица", "Научная фантастика", 1999, 8.7f));
    }
}