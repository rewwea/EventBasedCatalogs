using System;
using System.Collections.Generic;

public delegate void FilmEventHandler(Film film);

public class FilmCatalog
{
    private List<Film> films = new List<Film>();
    public event FilmEventHandler FilmAdded;

    public void AddFilm(Film film)
    {
        films.Add(film);
        OnFilmAdded(film);
    }

    public List<Film> GetAllFilms()
    {
        return films;
    }

    protected virtual void OnFilmAdded(Film film)
    {
        FilmAdded?.Invoke(film);
    }
}