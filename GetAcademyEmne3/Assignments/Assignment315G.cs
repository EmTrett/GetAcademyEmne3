namespace GetAcademyEmne3.Assignments;

public class Assignment315G
{
    public static void Run()
    {
        const int range = 250;
        var counts = new int[range];
        var text = "something";
        while (!string.IsNullOrWhiteSpace(text))
        {
            text = Console.ReadLine();
            if (text == null) continue;
            text = text.ToLower();
            var totalCount = text.Length;
            foreach (var character in text)
            {
                counts[(int)character]++;
            }

            OutputText(range, counts, totalCount);
        }
    }

    private static void OutputText(int range, int[] counts, int totalCount)
    {
        for (var i = 0; i < range; i++)
        {
            if (counts[i] <= 0) continue;
            var percentage = (counts[i] / (float)totalCount) * 100;
            var percent = percentage.ToString("n2");
            var character = (char)i;
            Console.WriteLine(character + " - " + counts[i] + $" {percent}%");
        }
    }
}