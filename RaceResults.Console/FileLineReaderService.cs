namespace RaceResults.Console;

public class FileLineReaderService
{
    public static string[] GetLines(string filename)
    {
        return File.ReadAllLines(filename);
    }
}