namespace GetAcademyEmne3.Assignments.Assignments321.Assignment321B;

public class Assignment321B
{
    public static void Run()
    {
        var movies = new List<Movie>();
        
        CreateMovies(_imdbTop250, movies);
        
        Display.Rules();
        Console.Write("Velg søk: ");
        var searchChoice = Console.ReadLine()?.ToUpper();
        Console.Write("Skriv in år: ");
        var year = Console.ReadLine()?.ToUpper();
        if (year == null) return;
        if (searchChoice != null)
            Display.FindMovies(searchChoice, year, movies);
    }

    private static void CreateMovies(string[,] simpleMovies, List<Movie> movies)
    {
        for (int i = 0; i < simpleMovies.GetLength(0); i++)
        {
            string title = simpleMovies[i, 0];
            string year = simpleMovies[i, 1];
            string rating = simpleMovies[i, 2];
            
            movies.Add(new Movie(title, year, rating));
        }
    }
    private static string[,] _imdbTop250 = new[,]
    {
        { "The Shawshank Redemption", "1994", "9.3" },
        { "The Godfather", "1972", "9.2" },
        { "The Dark Knight", "2008", "9.0" },
        { "The Godfather: Part II", "1974", "9.0" },
        { "12 Angry Men", "1957", "8.9" },
        { "Schindler's List", "1993", "9.0" },
        { "The Lord of the Rings: The Return of the King", "2003", "8.9" },
        { "Pulp Fiction", "1994", "8.9" },
        { "The Lord of the Rings: The Fellowship of the Ring", "2001", "8.8" },
        { "The Good, the Bad and the Ugly", "1966", "8.8" },
        { "Forrest Gump", "1994", "8.8" },
        { "Inception", "2010", "8.8" },
        { "Star Wars: Episode V - The Empire Strikes Back", "1980", "8.7" },
        { "The Matrix", "1999", "8.7" },
        { "Goodfellas", "1990", "8.7" },
        { "One Flew Over the Cuckoo's Nest", "1975", "8.7" },
        { "Se7en", "1995", "8.6" },
        { "City of God", "2002", "8.6" },
        { "Life Is Beautiful", "1997", "8.6" },
        { "The Silence of the Lambs", "1991", "8.6" },
        { "It's a Wonderful Life", "1946", "8.6" },
        { "Saving Private Ryan", "1998", "8.6" },
        { "Spirited Away", "2001", "8.6" },
        { "The Usual Suspects", "1995", "8.5" },
        { "Léon: The Professional", "1994", "8.5" }
    };
}