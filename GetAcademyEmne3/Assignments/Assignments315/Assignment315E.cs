namespace GetAcademyEmne3.Assignments;

public class Assignment315E
{
    public static void Run(int startValue, int endValue, int step)
    {
        var numbers = GetNumbers(startValue, endValue, step);

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
            if(current <= endValue) numbers.Add(current);
            else continue;
        }
    
        return numbers.ToArray();
    }
}