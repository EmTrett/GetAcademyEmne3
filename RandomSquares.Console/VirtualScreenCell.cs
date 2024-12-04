namespace RandomSquares.Console;

// ┬ ┤ ├ ┴
// ┌ ─ ┐ └ ┘ │
// ┼
public class VirtualScreenCell
{
    public bool Up { get; private set; }
    public bool Down { get; private set; }
    public bool Left { get; private set; }
    public bool Right { get; private set; }

    public char GetCharacter()
    {
        if (Up && Down && Left && Right)
        {
            return '\u253c'; //┼
        }

        if (Up && Down && !Left && !Right)
        {
            return '\u2502'; //│
        }

        if (Left && Right && !Up && !Down)
        {
            return '\u2500'; //─
        }

        if (Up && Right && !Down && !Left)
        {
            return '\u2518'; //┘
        }

        if (Down && Right && !Up && !Left)
        {
            return '\u2510'; //┐
        }

        if (Up && Left && !Down && !Right)
        {
            return '\u2514'; //└
        }

        if (Down && Left && !Up && !Right)
        {
            return '\u250c'; //└
        }

        if (Left && Right && Up && !Down)
        {
            return '\u2534'; //┴
        }

        if (Left && Right && Down && !Up)
        {
            return '\u252c'; //┬
        }

        if (Up && Down && Right && !Left)
        {
            return '\u2524'; //┤
        }

        if (Up && Down && Left && !Right)
        {
            return '\u251c'; //├
        }

        return ' ';
    }

    public void AddHorizontal()
    {
        Left = true;
        Right = true;
    }

    public void AddVertical()
    {
        Down = true;
        Up = true;
    }

    public void AddLowerLeftCorner()
    {
        Left = true;
        Up = true;
    }

    public void AddUpperLeftCorner()
    {
        Left = true;
        Down = true;
    }
    
    public void AddLowerRightCorner()
    {
        Right = true;
        Up = true;
    }

    public void AddUpperRightCorner()
    {
        Right = true;
        Down = true;
    }
}