namespace GetAcademyEmne3.Assignments.Assignments321.Assignment321B;

public static class Display
{
    public static void Rules()
    {
        Console.WriteLine("Regler: ");
        Console.WriteLine("Søk på år");
        Console.WriteLine("  * Y/y for filmer fra bestemt år");
        Console.WriteLine("  * YN/yn for filmer fra eller nyere en år");
        Console.WriteLine("  * YO/yo for filmer fra eller eldre en år");
    }

    public static void FindMovies(string searchType, string searchString, List<Movie> movies)
    {
        switch (searchType)
        {
            case "Y":
                FindMovieByYear(searchString, movies);
                break;
            case "YN":
                FindMovieNewerThan(searchString, movies);
                break;
            case "YO":
                FindMovieOlderThan(searchString, movies);
                break;
            default:
                InvalidSearch();
                break;
        }
    }

    private static void InvalidSearch(string error = "Provided search is invalid")
    {
        Console.Clear();
        Console.WriteLine($"{error}");
        Assignment321B.Run();
    }

    private static void FindMovieNewerThan(string searchString, List<Movie> movies)
    {
        Console.WriteLine("Funnet filmer: ");
        foreach (var movie in movies)
        {
            var search = Convert.ToInt32(searchString);
            var i = Convert.ToInt32(movie.ReleaseYear);
            if (i < search) continue;
            var name = movie.Title;
            var year = movie.ReleaseYear;
            var score = movie.MovieScore;
            Console.WriteLine($"{name}, {year}, {score}");
        }
    }
    private static void FindMovieOlderThan(string searchString, List<Movie> movies)
    {
        Console.WriteLine("Funnet filmer: ");
        foreach (var movie in movies)
        {
            var search = Convert.ToInt32(searchString);
            var i = Convert.ToInt32(movie.ReleaseYear);
            if (i > search) continue;
            var name = movie.Title;
            var year = movie.ReleaseYear;
            var score = movie.MovieScore;
            Console.WriteLine($"{name}, {year}, {score}");
        }
    }
    private static void FindMovieByYear(string searchString, List<Movie> movies)
    {
        Console.WriteLine("Funnet filmer: ");
        foreach (var movie in movies.Where(x => x.ReleaseYear.Contains(searchString)))
        {
            var name = movie.Title;
            var year = movie.ReleaseYear;
            var score = movie.MovieScore;
            Console.WriteLine($"{name}, {year}, {score}");
        }
    }
    

}