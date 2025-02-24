public class User
{
    public void OnFilmAdded(Film film)
    {
        Console.WriteLine($"[Пользователь] Я получил уведомление о новом фильме: {film.Title}");
    }
}