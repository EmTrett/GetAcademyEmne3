using GetAcademyEmne3.Assignments.Assignments323.Assignment323A;

namespace GetAcademyEmne3.Assignments.Assignments323.Assignment323B;

public class TwelveMatches()
{
    public List<Match> Matches = new();
    public TwelveMatches(string bet) : this()
    {
        var bets = bet.Split(',');
        for (var i = 0; i < 12; i++)
        {
            Matches.Add(new Match(bets[i].ToUpper()));
        }
    }
    public void AddGoal(int matchNumber, string teamCode)
    {
        var i = matchNumber - 1;
        switch (teamCode)
        {
            case "H":
                Matches[i].AddHomeGoals();
                break;
            case "B":
                Matches[i].AddAwayGoals();
                break;
        }
    }

    public void ShowAllScores()
    {
        Console.WriteLine("********************************");
        Console.WriteLine("Kamper:");
        for(var i = 0; i < 12; i++)
        {
            Console.WriteLine($"Match #{i + 1} stilling: {Matches[i].GetScore()}");
        }
        Console.WriteLine("********************************");
    }

    public void ShowCorrectCount()
    {
        var correctCount = 0;
        var i = 0;
        for (; i < Matches.Count; i++)
        {
            var match = Matches[i];
            if (match.IsBetCorrect()) correctCount++;
        }

        Console.WriteLine($"Antall rette kamper: {correctCount}");
        Console.WriteLine("********************************");
    }
}