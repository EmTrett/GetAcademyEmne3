namespace GetAcademyEmne3.Assignments.Assignments323.Assignment323A;

public class Match(string bet)
{
    public int HomeGoals { get; private set; }
    public int AwayGoals { get; private set; }
    public void AddHomeGoals() => HomeGoals++;
    public void AddAwayGoals() => AwayGoals++;

    public string ResultText()
    {
        var result = HomeGoals == AwayGoals ? "U" : HomeGoals > AwayGoals ? "H" : "B";
        var isBetCorrect = bet.Contains(result);
        var isBetCorrectText = isBetCorrect ? "riktig" : "feil";

        return isBetCorrectText;
    }
}