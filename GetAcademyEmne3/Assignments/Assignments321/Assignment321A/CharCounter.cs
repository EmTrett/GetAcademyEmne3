namespace GetAcademyEmne3.Assignments.Assignments321.Assignment321A;

public class CharCounter
{
    private const int Range = 250;
    private readonly int[] _counts = new int[Range];
    public void AddText(string text)
    {
        foreach (var character in text)
        {
            _counts[character]++;
        }
    }

    public void ShowCounts()
    {
        for (var i = 0; i < Range; i++)
        {
            if (_counts[i] > 0)
            {
                var character = (char)i;
                Console.WriteLine(character + " - " + _counts[i]);
            }
        }
    }
}