using System;

namespace StarsInterface.Console;

public class PhasesStar(Random random) : IStars
{
    private const string _phaseChars = " .x*x.";
    protected int _x = random.Next(1, System.Console.WindowWidth - 1);
    protected int _y = random.Next(1, System.Console.WindowHeight - 1);
    private int _phase = random.Next(0, _phaseChars.Length);

    public void Show()
    {
        System.Console.CursorLeft = _x;
        System.Console.CursorTop = _y;
        System.Console.Write(_phaseChars[_phase]);
    }

    public virtual void Update()
    {
        _phase++;
        if (_phase == _phaseChars.Length) _phase = 0;
    }
}