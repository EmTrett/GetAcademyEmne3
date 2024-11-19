namespace GetAcademyEmne3.Assignments.Assignments321.Assignment321B;

public class Movie
{
    public string Title { get; private set; }
    public string ReleaseYear { get; private set; }
    public string MovieScore { get; private set; }
    public Movie(string movieName, string year, string score)
    {
        Title = movieName;
        ReleaseYear = year;
        MovieScore = score;
    }
}