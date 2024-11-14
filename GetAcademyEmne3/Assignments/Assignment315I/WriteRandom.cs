namespace GetAcademyEmne3.Assignments.Assignment315I;

public abstract class WriteRandom
{
    private static readonly Random Random = new Random();
    public static char LowerCaseLetter()
    {
        var letter = GetRandomLetter('a', 'z');
        
        return letter;
    }  
    
    public static char UpperCaseLetter()
    { 
        var letter = GetRandomLetter('A', 'Z');
        
        return letter;
    }

    public static int Digit()
    {
        return Random.Next(1, 10);
    }

    public static char Symbol()
    {
        var symbols = new[] { '!', '@', '$', '%', '?', '&' };
        var index = Random.Next(symbols.Length);
        
        return symbols[index];
    }

    private static char GetRandomLetter(char min, char max)
    {
        return (char)Random.Next(min, max);
    }
}