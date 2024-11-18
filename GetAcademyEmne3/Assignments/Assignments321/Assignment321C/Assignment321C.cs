namespace GetAcademyEmne3.Assignments.Assignments321.Assignment321C;

public class Assignment321C
{
    public static void Run()
    {
        var coinCount = new List<Coin>();
        if (coinCount == null) throw new ArgumentNullException(nameof(coinCount));

        coinCount.Add(new Coin(1, 4));
        coinCount.Add(new Coin(5, 6));
        coinCount.Add(new Coin(10, 2));
        coinCount.Add(new Coin(20, 9));
        
        DisplaySumTotal(coinCount);
    }

    private static void DisplaySumTotal(List<Coin> coinCount)
    {
        var sum = 0;
        foreach (var coin in coinCount)
        {
            sum += coin.Sum;
        }

        Console.Write($"Total sum av alle mynter er {sum}");
    }
}