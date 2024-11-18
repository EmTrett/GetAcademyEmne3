namespace GetAcademyEmne3.Assignments.Assignments321.Assignment321C;

public class Coin(int value, int count)
{
    public int Value { get; private set; } = value;
    public int Count { get; private set; } = count;

    public int Sum => Value * Count;
}