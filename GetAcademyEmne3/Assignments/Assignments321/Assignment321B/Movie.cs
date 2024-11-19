namespace GetAcademyEmne3.Assignments.Assignments321.Assignment321B;

public class Movie(string movieName, string year, string score)
{
    public string Title { get; private set; } = movieName;
    public string ReleaseYear { get; private set; } = year;
    public string MovieScore { get; private set; } = score;
}