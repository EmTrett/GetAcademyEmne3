namespace GetAcademyEmne3.Assignments;

public class Assignment315D
{
    public static void Run()
    {
        Console.Write("Hello, enter text ");

        var input = Console.ReadLine();

        if (input != null) Console.WriteLine(CountWords(input));
    }
    private static string CountWords(string words)
    {
        var splitWords = words.Split(" ");
        var wordsCount = splitWords.Length;
        var longestWord = LongestWord(splitWords);
        return "Det er " + wordsCount + " ord i listen og det lengste ordet er: " + longestWord;
    }

    private static string LongestWord(string[] words)
    {
        var longestWord = string.Empty;
        foreach (var word in words)
        {
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }
        }
        return longestWord;
    }
}