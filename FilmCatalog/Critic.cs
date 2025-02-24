public class Critic
{
    public void OnFilmAdded(Film film)
    {
        if (film.Rating > 8.0f)
        {
            Console.WriteLine($"[Критик] Фильм \"{film.Title}\" имеет высокий рейтинг: {film.Rating}");
        }
    }
}