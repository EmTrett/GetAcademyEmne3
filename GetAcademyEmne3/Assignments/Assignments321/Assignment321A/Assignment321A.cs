namespace GetAcademyEmne3.Assignments.Assignments321.Assignment321A;

public class Assignment321A
{
    public static void Run()
    {
        var counter = new CharCounter();
        var text = "something";
        while (!string.IsNullOrWhiteSpace(text))
        {
            text = Console.ReadLine();
            if (text != null) counter.AddText(text);
            counter.ShowCounts();
        }
    }
}