namespace GetAcademyEmne3.Assignments;

public class Assignment315E
{
    public static void Run()
    {
        var numbers = GetNumbers(100, 1000, 25);

        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }

    private static int[] GetNumbers(int startValue, int endValue, int step)
    {
        var current = startValue;
        var numbers = new List<int> { current };
        while (current < endValue)
        {
            current += step;
            numbers.Add(current);
        }
    
        return numbers.ToArray();
    }
}