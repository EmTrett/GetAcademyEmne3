namespace GetAcademyEmne3.Assignments;

public class Assignment315C
{
    public static void Run()
    {
        Console.Write("Hello, please enter a text to reverse: ");
        var input = Console.ReadLine();
        var reversedInput = ReverseString(input);
        
        Console.WriteLine(reversedInput);
    }
    private static string ReverseString(string input)
    {
        var charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}