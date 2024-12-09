namespace ClickerWithInterface.Console;

public class ClickerGame()
{
    public int Points { get; private set;  } = 0;
    private int _pointsPerClick = 1;
    private int _pointsPerClickIncrease = 1;

    public void Click()
    {
        Points += _pointsPerClick;
    }

    public void PerClickUpgrade()
    {
        if (Points < 10) return;
        Points -= 10;
        _pointsPerClick += _pointsPerClickIncrease;
    }

    public void PerClickIncreaseUpgrade()
    {
        if (Points < 100) return;
        Points -= 100;
        _pointsPerClickIncrease++;
    }
}