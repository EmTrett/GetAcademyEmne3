namespace GetAcademyEmne3.Assignments.Assignments323.Assignment323A;

public class Match(string bet)
{
    private string Bet { get; } = bet;
    public int HomeGoals { get; private set; }
    public int AwayGoals { get; private set; }
    public void AddHomeGoals() => HomeGoals++;
    public void AddAwayGoals() => AwayGoals++;

    public bool IsBetCorrect()
    {
        var result = HomeGoals == AwayGoals ? "U" : HomeGoals > AwayGoals ? "H" : "B";
        var isBetCorrect = Bet.Contains(result);
        
        return isBetCorrect;
    }

    public string GetScore()
    {
        return $"{HomeGoals} - {AwayGoals}";
    }
}