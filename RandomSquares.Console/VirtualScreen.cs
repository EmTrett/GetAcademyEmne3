namespace RandomSquares.Console;

public class VirtualScreen
{
    private VirtualScreenRow[] _rows;

    public VirtualScreen(int width, int height)
    {
        _rows = new VirtualScreenRow[height + 1];

        for (int i = 0; i < _rows.Length; i++)
        {
            _rows[i] = new VirtualScreenRow(width);
        }
    }

    public void Add(Box box)
    {
        _rows[box.StartY].AddBoxTopRow(box.X, box.Width);
        _rows[box.EndY].AddBoxBottomRow(box.X, box.Width);

        for (int y = box.StartY + 1; y < box.EndY; y++)
        {
            _rows[y].AddBoxMiddleRow(box.X, box.Width);
        }
    }

    public void Show()
    {
        foreach (var row in _rows)
        {
            row.Show();
        }
    }
}