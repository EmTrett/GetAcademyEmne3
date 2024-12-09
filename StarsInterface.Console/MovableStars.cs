namespace StarsInterface.Console;

public class MovableStar(Random random) : IStars
{
    protected int _x = random.Next(1, System.Console.WindowWidth - 1);
    protected int _y = random.Next(1, System.Console.WindowHeight - 1);
    private int _speedX = random.Next(-1, 2);
    private int _speedY = random.Next(-1, 2);

    public void Update()
    {
        var windowWidth = System.Console.WindowWidth;
        var windowHeight = System.Console.WindowHeight;

        if (_x <= 1) _speedX = 1;
        if (_x >= windowWidth - 1) _speedX = -1;
        if (_y <= 1) _speedY = 1;
        if (_y >= windowHeight - 1) _speedY = -1;
        _x += _speedX;
        _y += _speedY;
    }

    public void Show()
    {
        System.Console.CursorLeft = _x;
        System.Console.CursorTop = _y;
        System.Console.Write('*');
    }
}