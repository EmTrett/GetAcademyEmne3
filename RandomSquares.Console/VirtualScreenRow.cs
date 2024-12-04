namespace RandomSquares.Console;

public class VirtualScreenRow
{

    private VirtualScreenCell[] _cells;

    public VirtualScreenRow(int screenWidth)
    {
        _cells = new VirtualScreenCell[screenWidth + 1];
        for (var i = 0; i < _cells.Length; i++)
        {
            _cells[i] = new VirtualScreenCell();
        }
    }

    public void AddBoxTopRow(int boxX, int boxWidth)
    {
        var startHorizontal = boxX + 1;
        var endHorizontal = boxX + boxWidth;

        for (var i = startHorizontal; i < endHorizontal; i++)
        {
            _cells[i].AddHorizontal();
        }
        
        _cells[boxX].AddUpperLeftCorner();
        _cells[endHorizontal].AddUpperRightCorner();
    }

    public void AddBoxBottomRow(int boxX, int boxWidth)
    {
        var startHorizontal = boxX + 1;
        var endHorizontal = boxX + boxWidth;

        for (var i = startHorizontal; i < endHorizontal; i++)
        {
            _cells[i].AddHorizontal();
        }
        
        _cells[boxX].AddLowerLeftCorner();
        _cells[endHorizontal].AddLowerRightCorner();
    }

    public void AddBoxMiddleRow(int boxX, int boxWidth)
    {
        var endHorizontal = boxX + boxWidth;
        _cells[boxX].AddVertical();
        _cells[endHorizontal].AddVertical();
    }

    public void Show()
    {
        string rowString = null;
        foreach (var cell in _cells)
        {
            rowString += cell.GetCharacter().ToString();
        }
        System.Console.WriteLine(rowString);
    }
}